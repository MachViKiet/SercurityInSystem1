--DO AN ATBM HTTT
--PHAN HE 1
--MSSV: 21127634 - Mach Vi Kiet
--MSSV: 21127609 - Nguyen Duc Vinh Hoa
--MSSV: 21127641 - Nguyen Xuan Loc
--MSSV: 21127660 - Doan Thi Yen Nhi
--Procedures

BEGIN EXECUTE IMMEDIATE 'DROP USER QL_TRUONGHOC_X CASCADE';
EXCEPTION WHEN OTHERS THEN
    IF SQLCODE != -1918 THEN RAISE;
    END IF;
END;

alter session set "_ORACLE_SCRIPT"=true;

CREATE USER QL_TRUONGHOC_X IDENTIFIED BY 123;
GRANT DBA TO QL_TRUONGHOC_X;
GRANT CREATE SESSION TO QL_TRUONGHOC_X WITH ADMIN OPTION;
GRANT CREATE USER, ALTER USER, DROP USER TO QL_TRUONGHOC_X;
GRANT CREATE VIEW TO QL_TRUONGHOC_X WITH ADMIN OPTION;


--XOA USER VA ROLE 
DECLARE
    CURSOR CUR_NHANSU IS (SELECT MANV FROM QL_TRUONGHOC_X.NHANSU
        WHERE MANV NOT IN (SELECT USERNAME FROM ALL_USERS));
    CURSOR CUR_SINHVIEN IS (SELECT MASV FROM QL_TRUONGHOC_X.SINHVIEN
        WHERE MASV NOT IN (SELECT USERNAME FROM ALL_USERS));
BEGIN
    FOR USR IN CUR_NHANSU LOOP
        BEGIN
            EXECUTE IMMEDIATE 'DROP USER ' || USR.MANV || ' CASCADE';
        EXCEPTION
            WHEN OTHERS THEN
                NULL; -- bo qua neu user khong ton tai
        END;
    END LOOP;
    FOR USR IN CUR_SINHVIEN LOOP
        BEGIN
            EXECUTE IMMEDIATE 'DROP USER ' || USR.MASV || ' CASCADE';
        EXCEPTION
            WHEN OTHERS THEN
                NULL; -- bo qua neu user khong ton tai
        END;
    END LOOP;
END;
/

ALTER SESSION SET CURRENT_SCHEMA = SYS;
DECLARE CURSOR CUR IS (SELECT "ROLE" AS RO FROM DBA_ROLES
        WHERE "ROLE" LIKE 'RL_%');
BEGIN
    FOR RL IN CUR LOOP
        EXECUTE IMMEDIATE 'DROP ROLE ' || RL.RO;
    END LOOP;
END;
/

--TAO USER VA ROLE
DECLARE
    CURSOR CUR_NHANSU IS (SELECT MANV FROM QL_TRUONGHOC_X.NHANSU
        WHERE MANV NOT IN (SELECT USERNAME FROM ALL_USERS));
    CURSOR CUR_SINHVIEN IS (SELECT MASV FROM QL_TRUONGHOC_X.SINHVIEN
        WHERE MASV NOT IN (SELECT USERNAME FROM ALL_USERS));
BEGIN
    FOR USR IN CUR_NHANSU LOOP
        EXECUTE IMMEDIATE 'CREATE USER ' || USR.MANV || ' IDENTIFIED BY 123';
        EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO ' || USR.MANV;
    END LOOP;
    FOR USR IN CUR_SINHVIEN LOOP
        EXECUTE IMMEDIATE 'CREATE USER ' || USR.MASV || ' IDENTIFIED BY 123';
        EXECUTE IMMEDIATE 'GRANT CREATE SESSION TO ' || USR.MASV;
    END LOOP;
END;
/

CREATE OR REPLACE PROCEDURE QL_TRUONGHOC_X.USP_ASSIGN_ROLES(
    RL VARCHAR2, WHO VARCHAR2, TAB VARCHAR2, COLN VARCHAR2
) 
AS 
    CUR SYS_REFCURSOR;  
    URS VARCHAR2(100);  
BEGIN
    OPEN CUR FOR 'SELECT ' || COLN || ' FROM ' || TAB ||
        ' WHERE ' || COLN || ' LIKE ''' || WHO || '%'' AND '
        || COLN || ' IN (SELECT USERNAME FROM ALL_USERS)';
    LOOP
        FETCH CUR INTO URS;
        EXIT WHEN CUR%NOTFOUND;
        EXECUTE IMMEDIATE 'GRANT RL_TRUONGHOC_' || RL || ' TO ' || URS;
    END LOOP;
    CLOSE CUR;
END;
/
--TAO ROLE
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;

CREATE ROLE RL_TRUONGHOC_NHANVIENCOBAN;
EXEC QL_TRUONGHOC_X.USP_ASSIGN_ROLES('NHANVIENCOBAN', 'NHAN VIEN CO BAN', 'NHANSU', 'VAITRO');

CREATE ROLE RL_TRUONGHOC_GIANGVIEN;
EXEC QL_TRUONGHOC_X.USP_ASSIGN_ROLES('GIANGVIEN', 'GIANG VIEN', 'NHANSU', 'VAITRO');

CREATE ROLE RL_TRUONGHOC_GIAOVU;
EXEC QL_TRUONGHOC_X.USP_ASSIGN_ROLES('GIAOVU', 'GIAO VU', 'NHANSU', 'VAITRO');

CREATE ROLE RL_TRUONGHOC_TRUONGDONVI;
EXEC QL_TRUONGHOC_X.USP_ASSIGN_ROLES('TRUONGDONVI', 'TRUONG DON VI', 'NHANSU', 'VAITRO');

CREATE ROLE RL_TRUONGHOC_TRUONGKHOA;
EXEC QL_TRUONGHOC_X.USP_ASSIGN_ROLES('TRUONGKHOA', 'TRUONG KHOA', 'NHANSU', 'VAITRO');

--CREATE ROLE RL_TRUONGHOC_SINHVIEN;
--EXEC QL_TRUONGHOC_X.USP_ASSIGN_ROLES('SINHVIEN', 'SV', 'SINHVIEN', 'MASV');

alter session set "_oracle_script"=true; 

--- PROCEDURE TAO USER MOI 
CREATE OR REPLACE PROCEDURE QL_TRUONGHOC_X.CREATE_USER(
    P_USERNAME IN VARCHAR2,
    P_PASSWORD IN VARCHAR2
)
AS
BEGIN
    EXECUTE IMMEDIATE ('ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE');
    EXECUTE IMMEDIATE ('CREATE USER ' || P_USERNAME || ' IDENTIFIED BY ' || P_PASSWORD);
    EXECUTE IMMEDIATE ('GRANT CREATE SESSION TO '|| P_USERNAME );
END;
/

--PROCUDURE XOA USER
CREATE OR REPLACE PROCEDURE QL_TRUONGHOC_X.DROP_USER(P_USERNAME IN VARCHAR2) 
AUTHID CURRENT_USER 
AS
BEGIN
        EXECUTE IMMEDIATE ('ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE');
    EXECUTE IMMEDIATE ('DROP USER ' || P_USERNAME);
END;
/ 

--PROCEDURE CHINH SUA USER
CREATE OR REPLACE PROCEDURE QL_TRUONGHOC_X.ALTER_USER(
    P_USERNAME IN VARCHAR2,
    P_PASSWORD IN VARCHAR2) 
AUTHID CURRENT_USER 
AS
BEGIN
    EXECUTE IMMEDIATE ('ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE');
   EXECUTE IMMEDIATE ('ALTER USER ' || P_USERNAME ||' IDENTIFIED BY '|| P_PASSWORD);
END;
/

--TAO VIEW XEM THONG TIN 
CREATE OR REPLACE VIEW QL_TRUONGHOC_X.V_THONGTINCANHAN_NHANSU
AS SELECT * FROM QL_TRUONGHOC_X.NHANSU
   WHERE not(MANV <> SYS_CONTEXT('USERENV', 'SESSION_USER')) ;
/

--PROCEDURE TAO ROLE MOI 
CREATE OR REPLACE PROCEDURE QL_TRUONGHOC_X.CREATE_ROLE(
    P_ROLENAME IN VARCHAR2,
    P_PASSWORD IN VARCHAR2
)
AUTHID CURRENT_USER 
AS
BEGIN
    EXECUTE IMMEDIATE ('ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE');
    IF(P_PASSWORD = '') THEN
        EXECUTE IMMEDIATE ('CREATE ROLE RL_TRUONGHOC_' || P_ROLENAME);
    END IF;
    EXECUTE IMMEDIATE ('CREATE ROLE RL_TRUONGHOC_' || P_ROLENAME ||' IDENTIFIED BY '||P_PASSWORD);
END;
/

--PROCEDURE XOA ROLE 
CREATE OR REPLACE PROCEDURE QL_TRUONGHOC_X.DROP_ROLE(
    P_ROLENAME IN VARCHAR2
)
AUTHID CURRENT_USER 
AS
BEGIN
    EXECUTE IMMEDIATE ('ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE');
    EXECUTE IMMEDIATE ('DROP ROLE ' || P_ROLENAME);
END;
/

--PROCEDURE CHINH SUA ROLE 
CREATE OR REPLACE PROCEDURE QL_TRUONGHOC_X.ALTER_ROLE(
    P_ROLENAME IN VARCHAR2,
    P_PASSWORD IN VARCHAR2
)
AUTHID CURRENT_USER 
AS
BEGIN
    EXECUTE IMMEDIATE ('ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE');
    EXECUTE IMMEDIATE ('ALTER ROLE ' || P_ROLENAME ||' IDENTIFIED BY '||P_PASSWORD);
END;
/ 

--PROCEDURE PHAN QUYEN CHO USER 
CREATE OR REPLACE PROCEDURE QL_TRUONGHOC_X.GRANT_PRIVS_USER(
    P_USERNAME IN VARCHAR2,
    P_PRIVSNAME IN VARCHAR2,
    P_OBJECTNAME IN VARCHAR2,
    GRANT_OPTION IN VARCHAR2)
AUTHID CURRENT_USER
AS
BEGIN
    IF(GRANT_OPTION = 'NO') THEN
        EXECUTE IMMEDIATE ('GRANT '||P_PRIVSNAME||' ON '||P_OBJECTNAME||' TO '||P_USERNAME);
    ELSIF(GRANT_OPTION = 'YES') THEN 
        EXECUTE IMMEDIATE ('GRANT '||P_PRIVSNAME||' ON '||P_OBJECTNAME||' TO '||P_USERNAME||' WITH GRANT OPTION ');
    ELSIF(P_OBJECTNAME = 'NONE') THEN
        EXECUTE IMMEDIATE ('GRANT '||P_PRIVSNAME||' TO '||P_USERNAME);
    END IF;
END;
/

--PROCEDURE PHAN QUYEN CHO ROLE
CREATE OR REPLACE PROCEDURE QL_TRUONGHOC_X.GRANT_PRIVS_ROLE(
    P_ROLENAME IN VARCHAR2,
    P_PRIVSNAME IN VARCHAR2,
    P_OBJECTNAME IN VARCHAR2)
AUTHID CURRENT_USER
AS
BEGIN
    EXECUTE IMMEDIATE ('GRANT '||P_PRIVSNAME||' ON '||P_OBJECTNAME||' TO '||P_ROLENAME);
END;
/

--PROCEDURE THU HOI QUYEN CUA ROLE
CREATE OR REPLACE PROCEDURE QL_TRUONGHOC_X.REVOKE_PRIVS_ROLE(
    P_ROLENAME IN VARCHAR2,
    P_PRIVSNAME IN VARCHAR2,
    P_OBJECTNAME IN VARCHAR2)
AUTHID CURRENT_USER
AS
BEGIN
    EXECUTE IMMEDIATE ('REVOKE '||P_PRIVSNAME||' ON '||P_OBJECTNAME||' FROM '||P_ROLENAME);
END;
/

--PROCEDURE GAN ROLE CHO USER
CREATE OR REPLACE PROCEDURE QL_TRUONGHOC_X.GRANT_ROLE_TO_USER(
    P_ROLENAME IN VARCHAR2,
    P_USERNAME IN VARCHAR2)
AUTHID CURRENT_USER
AS
BEGIN
    EXECUTE IMMEDIATE ('GRANT '||P_ROLENAME||' TO '||P_USERNAME);
END;
/

--PROCEDURE THU HOI QUYEN CUA USER
CREATE OR REPLACE PROCEDURE QL_TRUONGHOC_X.REVOKE_ROLE_TO_USER(
    P_ROLENAME IN VARCHAR2,
    P_USERNAME IN VARCHAR2)
AUTHID CURRENT_USER
AS
BEGIN
    EXECUTE IMMEDIATE ('REVOKE '||P_ROLENAME||' FROM '||P_USERNAME);
END;
/