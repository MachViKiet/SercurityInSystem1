--DO AN ATBM HTTT
--PHAN HE 1
--MSSV: 21127634 - Mach Vi Kiet
--MSSV: 21127609 - Nguyen Duc Vinh Hoa
--MSSV: 21127641 - Nguyen Xuan Loc
--MSSV: 21127660 - Doan Thi Yen Nhi
--DATA
--DU LIEU BANG DON VI
INSERT INTO QL_TRUONGHOC_X.DONVI (MADV, TENDV, TRUONGDONVI)
    SELECT 'VPK01','Van Phong Khoa', null from dual union all
    SELECT 'HTTT1','Bo Mon He Thong Thong Tin', null from dual union all
    SELECT 'CNPM1','Bo Mon Cong Nghe Phan Mem', null from dual union all
    SELECT 'CNTT1','Bo Mon Cong Nghe Thong Tin', null from dual union all
    SELECT 'TGMT1','Bo Mon Thi Giac May Tinh', null from dual union all
    SELECT 'MTTVT','Bo Mon Mang May Tinh Va Vien Thong', null from dual ;
--DU LIEU CHO BANG NHANSU
insert into QL_TRUONGHOC_X.NHANSU (MANV, HOTEN, PHAI, NGAYSINH, PHUCAP, DT, VAITRO, MADV)
    -- TRUONG KHOA
    SELECT 'NV001', 'Nhan su 1', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'TRUONG KHOA', 'HTTT1' from dual union all 
    -- TRUONG DON VI
    SELECT 'NV002', 'Nhan su 2', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'TRUONG DON VI', 'HTTT1' from dual union all 
    SELECT 'NV003', 'Nhan su 3', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'TRUONG DON VI', 'VPK01' from dual union all 
    SELECT 'NV004', 'Nhan su 4', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'TRUONG DON VI', 'CNPM1' from dual union all 
    SELECT 'NV005', 'Nhan su 5', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'TRUONG DON VI', 'MTTVT' from dual union all 
    SELECT 'NV006', 'Nhan su 6', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'TRUONG DON VI', 'TGMT1' from dual union all 
    SELECT 'NV007', 'Nhan su 7', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'TRUONG DON VI', 'CNTT1' from dual union all 
    -- GIAO VU
    SELECT 'NV008', 'Nhan su 8', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'GIAO VU', 'VPK01' from dual union all 
    SELECT 'NV009', 'Nhan su 9', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'GIAO VU', 'VPK01' from dual union all 
    SELECT 'NV010', 'Nhan su 10', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'GIAO VU', 'VPK01' from dual union all 
    SELECT 'NV011', 'Nhan su 11', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'GIAO VU', 'VPK01' from dual union all 
    SELECT 'NV012', 'Nhan su 12', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'GIAO VU', 'VPK01' from dual union all 
    SELECT 'NV013', 'Nhan su 13', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'GIAO VU', 'VPK01' from dual union all 
    SELECT 'NV014', 'Nhan su 14', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'GIAO VU', 'VPK01' from dual union all 
    SELECT 'NV015', 'Nhan su 15', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'GIAO VU', 'VPK01' from dual union all 
    SELECT 'NV016', 'Nhan su 16', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'GIAO VU', 'VPK01' from dual union all 
    SELECT 'NV017', 'Nhan su 17', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'GIAO VU', 'VPK01' from dual union all 
    -- NHAN VIEN CO BAN
    SELECT 'NV018', 'Nhan su 18', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'NHAN VIEN CO BAN', 'VPK01' from dual union all 
    SELECT 'NV019', 'Nhan su 19', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'NHAN VIEN CO BAN', 'VPK01' from dual union all 
    SELECT 'NV020', 'Nhan su 20', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'NHAN VIEN CO BAN', 'VPK01' from dual union all 
    SELECT 'NV021', 'Nhan su 21', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'NHAN VIEN CO BAN', 'VPK01' from dual union all 
    SELECT 'NV022', 'Nhan su 22', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'NHAN VIEN CO BAN', 'VPK01' from dual union all 
    SELECT 'NV023', 'Nhan su 23', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'NHAN VIEN CO BAN', 'VPK01' from dual union all 
    SELECT 'NV024', 'Nhan su 24', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'NHAN VIEN CO BAN', 'VPK01' from dual union all 
    SELECT 'NV025', 'Nhan su 25', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'NHAN VIEN CO BAN', 'VPK01' from dual union all 
    SELECT 'NV026', 'Nhan su 26', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'NHAN VIEN CO BAN', 'VPK01' from dual union all 
    SELECT 'NV027', 'Nhan su 27', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'NHAN VIEN CO BAN', 'VPK01' from dual union all
    -- GIANG VIEN 
    SELECT 'NV047', 'Nhan su 47', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'GIANG VIEN', 'HTTT1' from dual union all 
    SELECT 'NV046', 'Nhan su 46', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'GIANG VIEN', 'HTTT1' from dual union all 
    SELECT 'NV045', 'Nhan su 45', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'GIANG VIEN', 'CNPM1' from dual union all 
    SELECT 'NV044', 'Nhan su 44', 'N', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'GIANG VIEN', 'CNPM1' from dual union all 
    SELECT 'NV043', 'Nhan su 43', '', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'GIANG VIEN', 'CNTT1' from dual union all 
    SELECT 'NV042', 'Nhan su 42', '', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'GIANG VIEN', 'CNTT1' from dual union all 
    SELECT 'NV041', 'Nhan su 41', '', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'GIANG VIEN', 'TGMT1' from dual union all 
    SELECT 'NV040', 'Nhan su 40', '', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'GIANG VIEN', 'TGMT1' from dual union all 
    SELECT 'NV039', 'Nhan su 39', '', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'GIANG VIEN', 'MTTVT' from dual union all 
    SELECT 'NV038', 'Nhan su 38', '', TO_DATE('1988-10-20','YYYY-MM-DD'), 200000, '1234567899', 'GIANG VIEN', 'MTTVT' from dual;

--DU LIEU BANG SINH VIEN
INSERT INTO QL_TRUONGHOC_X.SINHVIEN 
    SELECT 'SV210002', 'Sinh vien 2', 'N', TO_DATE('2003-10-20','YYYY-MM-DD'), 'TPHCM', '9876543211', 'CQ', 'HTTT', 3, null from dual union all
    SELECT 'SV210001', 'Sinh vien 1', 'N', TO_DATE('2003-10-20','YYYY-MM-DD'), 'TPHCM', '9876543211', 'CQ', 'HTTT', 3, 8.5 from dual union all 
    SELECT 'SV210003', 'Sinh vien 3', 'N', TO_DATE('2003-10-20','YYYY-MM-DD'), 'TPHCM', '9876543211', 'CQ', 'CNTT', 3, 8.5 from dual union all 
    SELECT 'SV210004', 'Sinh vien 4', 'N', TO_DATE('2003-10-20','YYYY-MM-DD'), 'TPHCM', '9876543211', 'CQ', 'TGMT', 3, 8.5 from dual union all 
    SELECT 'SV210005', 'Sinh vien 5', 'N', TO_DATE('2003-10-20','YYYY-MM-DD'), 'TPHCM', '9876543211', 'CQ', 'CNTT', 3, 8.5 from dual union all 
    SELECT 'SV210006', 'Sinh vien 6', 'N', TO_DATE('2003-10-20','YYYY-MM-DD'), 'TPHCM', '9876543211', 'CQ', 'MTTV', 3, 8.5 from dual union all 
    SELECT 'SV210007', 'Sinh vien 7', 'N', TO_DATE('2003-10-20','YYYY-MM-DD'), 'TPHCM', '9876543211', 'CQ', 'MTTV', 3, 8.5 from dual union all 
    SELECT 'SV210008', 'Sinh vien 8', 'N', TO_DATE('2003-10-20','YYYY-MM-DD'), 'TPHCM', '9876543211', 'CQ', 'TGMT', 3, 8.5 from dual union all 
    SELECT 'SV210009', 'Sinh vien 9', 'N', TO_DATE('2003-10-20','YYYY-MM-DD'), 'TPHCM', '9876543211', 'CQ', 'CNTT', 3, 8.5 from dual union all 
    SELECT 'SV210010', 'Sinh vien 10', 'N', TO_DATE('2003-10-20','YYYY-MM-DD'), 'TPHCM', '9876543211', 'CQ', 'CNPM', 3, 8.5 from dual; 
