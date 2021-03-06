USE [TN_CSDLPT]
GO
/****** Object:  StoredProcedure [dbo].[SP_THONG_THI]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP PROCEDURE [dbo].[SP_THONG_THI]
GO
/****** Object:  StoredProcedure [dbo].[SP_TAO_TAI_KHOAN]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP PROCEDURE [dbo].[SP_TAO_TAI_KHOAN]
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_THONG_TIN_DANG_NHAP_SINHVIEN]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP PROCEDURE [dbo].[SP_LAY_THONG_TIN_DANG_NHAP_SINHVIEN]
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_THONG_TIN_DANG_NHAP]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP PROCEDURE [dbo].[SP_LAY_THONG_TIN_DANG_NHAP]
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_MA_BANG_DIEM]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP PROCEDURE [dbo].[SP_LAY_MA_BANG_DIEM]
GO
/****** Object:  StoredProcedure [dbo].[SP_lAY_CAU_HOI]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP PROCEDURE [dbo].[SP_lAY_CAU_HOI]
GO
/****** Object:  StoredProcedure [dbo].[SP_KT_MON_HOC_TON_TAI]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP PROCEDURE [dbo].[SP_KT_MON_HOC_TON_TAI]
GO
/****** Object:  StoredProcedure [dbo].[SP_KIEM_TRA_SV]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP PROCEDURE [dbo].[SP_KIEM_TRA_SV]
GO
/****** Object:  StoredProcedure [dbo].[SP_KIEM_TRA_MA_SV]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP PROCEDURE [dbo].[SP_KIEM_TRA_MA_SV]
GO
/****** Object:  StoredProcedure [dbo].[SP_KIEM_MA_LOP]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP PROCEDURE [dbo].[SP_KIEM_MA_LOP]
GO
/****** Object:  StoredProcedure [dbo].[SP_KIEM_MA_KHOA]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP PROCEDURE [dbo].[SP_KIEM_MA_KHOA]
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_BANG_DIEM]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP PROCEDURE [dbo].[SP_INSERT_BANG_DIEM]
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_BAI_THI_NEW]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP PROCEDURE [dbo].[SP_INSERT_BAI_THI_NEW]
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_BAI_THI]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP PROCEDURE [dbo].[SP_INSERT_BAI_THI]
GO
/****** Object:  StoredProcedure [dbo].[SP_IN_DS_BANG_DIEM]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP PROCEDURE [dbo].[SP_IN_DS_BANG_DIEM]
GO
/****** Object:  StoredProcedure [dbo].[SP_IN_BAI_THI]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP PROCEDURE [dbo].[SP_IN_BAI_THI]
GO
/****** Object:  StoredProcedure [dbo].[SP_DS_DANG_KY_THI]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP PROCEDURE [dbo].[SP_DS_DANG_KY_THI]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] DROP CONSTRAINT [CK_TRINHDO]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] DROP CONSTRAINT [CK_THOIGIAN]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] DROP CONSTRAINT [CK_SOCAUTHI]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] DROP CONSTRAINT [CK_LAN]
GO
ALTER TABLE [dbo].[BODE] DROP CONSTRAINT [CK_DAPAN]
GO
ALTER TABLE [dbo].[BODE] DROP CONSTRAINT [CK_BODE]
GO
ALTER TABLE [dbo].[BANGDIEM] DROP CONSTRAINT [repl_identity_range_4841952A_E70A_4717_9C38_C3528D6EE139]
GO
ALTER TABLE [dbo].[BANGDIEM] DROP CONSTRAINT [CK_LANTHI]
GO
ALTER TABLE [dbo].[BANGDIEM] DROP CONSTRAINT [CK_DIEM]
GO
ALTER TABLE [dbo].[BAITHI] DROP CONSTRAINT [repl_identity_range_D2698181_4134_4AA8_9951_23FA3476B75F]
GO
ALTER TABLE [dbo].[SINHVIEN] DROP CONSTRAINT [FK_SINHVIEN_LOP]
GO
ALTER TABLE [dbo].[LOP] DROP CONSTRAINT [FK_LOP_KHOA]
GO
ALTER TABLE [dbo].[KHOA] DROP CONSTRAINT [FK_KHOA_COSO]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] DROP CONSTRAINT [FK_GIAOVIEN_DANGKY_MONHOC1]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] DROP CONSTRAINT [FK_GIAOVIEN_DANGKY_LOP_]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] DROP CONSTRAINT [FK_GIAOVIEN_DANGKY_GIAOVIEN1]
GO
ALTER TABLE [dbo].[GIAOVIEN] DROP CONSTRAINT [FK_GIAOVIEN_KHOA]
GO
ALTER TABLE [dbo].[BODE] DROP CONSTRAINT [FK_BODE_MONHOC]
GO
ALTER TABLE [dbo].[BODE] DROP CONSTRAINT [FK_BODE_GIAOVIEN]
GO
ALTER TABLE [dbo].[BANGDIEM] DROP CONSTRAINT [FK_BANGDIEM_SINHVIEN1]
GO
ALTER TABLE [dbo].[BANGDIEM] DROP CONSTRAINT [FK_BANGDIEM_MONHOC]
GO
ALTER TABLE [dbo].[BAITHI] DROP CONSTRAINT [FK_BAITHI_BANGDIEM]
GO
/****** Object:  Index [UN_TENMH]    Script Date: 7/31/2021 7:42:50 PM ******/
ALTER TABLE [dbo].[MONHOC] DROP CONSTRAINT [UN_TENMH]
GO
/****** Object:  Index [UN_TENLOP]    Script Date: 7/31/2021 7:42:50 PM ******/
ALTER TABLE [dbo].[LOP] DROP CONSTRAINT [UN_TENLOP]
GO
/****** Object:  Index [UQ__BANGDIEM__603FFF88E07C4574]    Script Date: 7/31/2021 7:42:50 PM ******/
ALTER TABLE [dbo].[BANGDIEM] DROP CONSTRAINT [UQ__BANGDIEM__603FFF88E07C4574]
GO
/****** Object:  View [dbo].[V_DS_PHANMANH]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP VIEW [dbo].[V_DS_PHANMANH]
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP TABLE [dbo].[SINHVIEN]
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP TABLE [dbo].[MONHOC]
GO
/****** Object:  Table [dbo].[LOP]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP TABLE [dbo].[LOP]
GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP TABLE [dbo].[KHOA]
GO
/****** Object:  Table [dbo].[GIAOVIEN_DANGKY]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP TABLE [dbo].[GIAOVIEN_DANGKY]
GO
/****** Object:  Table [dbo].[GIAOVIEN]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP TABLE [dbo].[GIAOVIEN]
GO
/****** Object:  Table [dbo].[COSO]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP TABLE [dbo].[COSO]
GO
/****** Object:  Table [dbo].[BODE]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP TABLE [dbo].[BODE]
GO
/****** Object:  Table [dbo].[BANGDIEM]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP TABLE [dbo].[BANGDIEM]
GO
/****** Object:  Table [dbo].[BAITHI]    Script Date: 7/31/2021 7:42:50 PM ******/
DROP TABLE [dbo].[BAITHI]
GO
/****** Object:  Table [dbo].[BAITHI]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BAITHI](
	[STT] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[CAUHOI] [int] NULL,
	[NOIDUNG] [ntext] NULL,
	[A] [ntext] NULL,
	[B] [ntext] NULL,
	[C] [ntext] NULL,
	[D] [ntext] NULL,
	[DAPAN] [char](1) NULL,
	[SVTRON] [char](1) NULL,
	[MABD] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_B0A9457E94D64489B209F8CDC4123F56]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_BAITHI_1] PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BANGDIEM]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BANGDIEM](
	[MASV] [char](8) NOT NULL,
	[MAMH] [char](5) NOT NULL,
	[LAN] [smallint] NOT NULL,
	[NGAYTHI] [datetime] NULL,
	[DIEM] [float] NULL,
	[MABD] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_0F81F547E1E14DB296D9077CAFDCD3C5]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_BANGDIEM] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC,
	[MAMH] ASC,
	[LAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BODE]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BODE](
	[CAUHOI] [int] NOT NULL,
	[MAMH] [char](5) NULL,
	[TRINHDO] [char](1) NULL,
	[NOIDUNG] [ntext] NULL,
	[A] [ntext] NULL,
	[B] [ntext] NULL,
	[C] [ntext] NULL,
	[D] [ntext] NULL,
	[DAP_AN] [char](1) NULL,
	[MAGV] [char](8) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_7942A3351F9E42BC9D74091C558C9A6E]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_BODE] PRIMARY KEY CLUSTERED 
(
	[CAUHOI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[COSO]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COSO](
	[MACS] [nchar](3) NOT NULL,
	[TENCS] [nvarchar](50) NOT NULL,
	[DIACHI] [nvarchar](100) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_E8967EC5ED474AE6AE75F472EF584E0C]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_COSO] PRIMARY KEY CLUSTERED 
(
	[MACS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GIAOVIEN]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GIAOVIEN](
	[MAGV] [char](8) NOT NULL,
	[HO] [varchar](40) NULL,
	[TEN] [varchar](40) NULL,
	[DIACHI] [varchar](50) NULL,
	[MAKH] [nchar](8) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_74850150035A40C1BF2F354490845F1C]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_GIAOVIEN] PRIMARY KEY CLUSTERED 
(
	[MAGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GIAOVIEN_DANGKY]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GIAOVIEN_DANGKY](
	[MAGV] [char](8) NULL,
	[MAMH] [char](5) NOT NULL,
	[MALOP] [char](8) NOT NULL,
	[TRINHDO] [char](1) NULL,
	[NGAYTHI] [datetime] NULL,
	[LAN] [smallint] NOT NULL,
	[SOCAUTHI] [smallint] NULL,
	[THOIGIAN] [smallint] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_9805016454BF4EF98AE922CC65C019BC]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_GIAOVIEN_DANGKY] PRIMARY KEY CLUSTERED 
(
	[MAMH] ASC,
	[MALOP] ASC,
	[LAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOA](
	[MAKH] [nchar](8) NOT NULL,
	[TENKH] [nvarchar](50) NOT NULL,
	[MACS] [nchar](3) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_BD37D8009B0547958371EFBBF6C21A95]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_KHOA] PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOP]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOP](
	[MALOP] [char](8) NOT NULL,
	[TENLOP] [varchar](40) NOT NULL,
	[MAKH] [nchar](8) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_14B5ABDA49C74471AD65BB04DB61DBE9]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_LOP] PRIMARY KEY CLUSTERED 
(
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MAMH] [char](5) NOT NULL,
	[TENMH] [varchar](40) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_4C31A590CBCA460D83B67EBDFD5E2146]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_TENMH] PRIMARY KEY CLUSTERED 
(
	[MAMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MASV] [char](8) NOT NULL,
	[HO] [varchar](40) NULL,
	[TEN] [varchar](10) NULL,
	[NGAYSINH] [datetime] NULL,
	[DIACHI] [varchar](40) NULL,
	[MALOP] [char](8) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL CONSTRAINT [MSmerge_df_rowguid_A2A6BE9108EB4F37B60AD37B9D3E8C54]  DEFAULT (newsequentialid()),
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[V_DS_PHANMANH]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V_DS_PHANMANH]
AS
SELECT  TENCN=PUBS.description, TENSERVER= subscriber_server
   FROM dbo.sysmergepublications PUBS,  dbo.sysmergesubscriptions SUBS
   WHERE PUBS.pubid= SUBS.PUBID  AND PUBS.publisher <> SUBS.subscriber_server

GO
SET IDENTITY_INSERT [dbo].[BAITHI] ON 

INSERT [dbo].[BAITHI] ([STT], [CAUHOI], [NOIDUNG], [A], [B], [C], [D], [DAPAN], [SVTRON], [MABD], [rowguid]) VALUES (70012, 1, N'In order to place a call outside the office, you have to .......nine first.', N'tip', N'make', N'dial', N'number', N'D', N'B', 70004, N'7a3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BAITHI] ([STT], [CAUHOI], [NOIDUNG], [A], [B], [C], [D], [DAPAN], [SVTRON], [MABD], [rowguid]) VALUES (70013, 2, N'Unfortunately, neither Mr.Sachs....... Ms Flynn will be able to attend the awards banquet this evening', N'but', N'and', N'nor', N'either', N'C', N'B', 70004, N'7b3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BAITHI] ([STT], [CAUHOI], [NOIDUNG], [A], [B], [C], [D], [DAPAN], [SVTRON], [MABD], [rowguid]) VALUES (70014, 3, N'Many employees seem more ....... now about how to use the new telephone system than they did before they attended the workshop', N'confusion', N'confuse', N'confused', N'confusing', N'C', N'A', 70004, N'7c3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BAITHI] ([STT], [CAUHOI], [NOIDUNG], [A], [B], [C], [D], [DAPAN], [SVTRON], [MABD], [rowguid]) VALUES (70015, 4, N'If you send in an order ....... mail, we recommend that you phone our sales division directly to confirm the order.', N'near', N'by', N'for', N'on', N'A', N'B', 70004, N'7d3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BAITHI] ([STT], [CAUHOI], [NOIDUNG], [A], [B], [C], [D], [DAPAN], [SVTRON], [MABD], [rowguid]) VALUES (70016, 5, N'It has been predicted that an.......weak dollar will stimulate tourism in the United States', N'increased', N'increasingly', N'increases', N'increase', N'B', N'D', 70004, N'7e3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BAITHI] ([STT], [CAUHOI], [NOIDUNG], [A], [B], [C], [D], [DAPAN], [SVTRON], [MABD], [rowguid]) VALUES (70017, 6, N'On international shipments, all duties and taxes are paid by the..........', N'recipient', N'receiving', N'receipt', N'receptive', N'A', N'C', 70004, N'7f3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BAITHI] ([STT], [CAUHOI], [NOIDUNG], [A], [B], [C], [D], [DAPAN], [SVTRON], [MABD], [rowguid]) VALUES (70018, 8, N'All full-time staff are eligible to participate in the revised health plan, which becomes effective the first ......... the month.', N'of', N'to', N'from', N'for', N'A', N'C', 70004, N'803b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BAITHI] ([STT], [CAUHOI], [NOIDUNG], [A], [B], [C], [D], [DAPAN], [SVTRON], [MABD], [rowguid]) VALUES (70019, 9, N'Passengers should allow for...... travel time to the airport in rush hour traffic', N'addition', N'additive', N'additionally', N'additional', N'D', N'B', 70004, N'813b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BAITHI] ([STT], [CAUHOI], [NOIDUNG], [A], [B], [C], [D], [DAPAN], [SVTRON], [MABD], [rowguid]) VALUES (70020, 10, N'It has been suggested that employees ........to work in their current positions until the quarterly review is finished.', N'continuity', N'continue', N'continuing', N'continuous', N'B', N'C', 70004, N'823b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BAITHI] ([STT], [CAUHOI], [NOIDUNG], [A], [B], [C], [D], [DAPAN], [SVTRON], [MABD], [rowguid]) VALUES (72021, 1, N'Unfortunately, neither Mr.Sachs....... Ms Flynn will be able to attend the awards banquet this evening', N'but', N'and', N'nor', N'either', N'C', N' ', 72005, N'b5396f6b-8af0-eb11-8a77-34cff68b29d6')
INSERT [dbo].[BAITHI] ([STT], [CAUHOI], [NOIDUNG], [A], [B], [C], [D], [DAPAN], [SVTRON], [MABD], [rowguid]) VALUES (72022, 2, N'According to the manufacturer, the new generatir is capable of....... the amount of power consumed by our facility by nearly ten percent.', N'reduced', N'reducing', N'reduce', N'reduces', N'B', N' ', 72005, N'b6396f6b-8af0-eb11-8a77-34cff68b29d6')
INSERT [dbo].[BAITHI] ([STT], [CAUHOI], [NOIDUNG], [A], [B], [C], [D], [DAPAN], [SVTRON], [MABD], [rowguid]) VALUES (72023, 3, N'One of the most frequent complaints among airline passengers is that there is not ...... legroom', N'enough', N'many', N'very', N'plenty', N'A', N' ', 72005, N'b7396f6b-8af0-eb11-8a77-34cff68b29d6')
INSERT [dbo].[BAITHI] ([STT], [CAUHOI], [NOIDUNG], [A], [B], [C], [D], [DAPAN], [SVTRON], [MABD], [rowguid]) VALUES (72024, 4, N'Faculty members are planning to..... a party in honor of Dr.Walker, who will retire at the end of the semester', N'carry', N'do', N'hold', N'take', N'D', N' ', 72005, N'b8396f6b-8af0-eb11-8a77-34cff68b29d6')
INSERT [dbo].[BAITHI] ([STT], [CAUHOI], [NOIDUNG], [A], [B], [C], [D], [DAPAN], [SVTRON], [MABD], [rowguid]) VALUES (72025, 5, N'We were........unaware of the problems with the air-conidtioning units in the hotel rooms until this week.', N'complete', N'completely', N'completed', N'completing', N'D', N' ', 72005, N'b9396f6b-8af0-eb11-8a77-34cff68b29d6')
INSERT [dbo].[BAITHI] ([STT], [CAUHOI], [NOIDUNG], [A], [B], [C], [D], [DAPAN], [SVTRON], [MABD], [rowguid]) VALUES (72026, 6, N'A recent global survey suggests.......... demand for aluminum and tin will remain at its current level for the next five to ten years.', N'which', N'it', N'that', N'both', N'C', N' ', 72005, N'ba396f6b-8af0-eb11-8a77-34cff68b29d6')
INSERT [dbo].[BAITHI] ([STT], [CAUHOI], [NOIDUNG], [A], [B], [C], [D], [DAPAN], [SVTRON], [MABD], [rowguid]) VALUES (72027, 7, N'Rates for the use of recreational facilities do not include ta and are subject to change without.........', N'signal', N'cash', N'report', N'notice', N'A', N' ', 72005, N'bb396f6b-8af0-eb11-8a77-34cff68b29d6')
INSERT [dbo].[BAITHI] ([STT], [CAUHOI], [NOIDUNG], [A], [B], [C], [D], [DAPAN], [SVTRON], [MABD], [rowguid]) VALUES (72028, 8, N'It has been predicted that an.......weak dollar will stimulate tourism in the United States', N'increased', N'increasingly', N'increases', N'increase', N'B', N' ', 72005, N'bc396f6b-8af0-eb11-8a77-34cff68b29d6')
INSERT [dbo].[BAITHI] ([STT], [CAUHOI], [NOIDUNG], [A], [B], [C], [D], [DAPAN], [SVTRON], [MABD], [rowguid]) VALUES (72029, 9, N'The firm is not liable for damage resulting from circumstances.........its control.', N'beyond', N'above', N'inside', N'around', N'A', N' ', 72005, N'bd396f6b-8af0-eb11-8a77-34cff68b29d6')
INSERT [dbo].[BAITHI] ([STT], [CAUHOI], [NOIDUNG], [A], [B], [C], [D], [DAPAN], [SVTRON], [MABD], [rowguid]) VALUES (72030, 10, N'Although the textbook gives a definitive answer,wise managers will look for........ own creative solutions', N'them', N'their', N'theirs', N'they', N'B', N' ', 72005, N'be396f6b-8af0-eb11-8a77-34cff68b29d6')
SET IDENTITY_INSERT [dbo].[BAITHI] OFF
SET IDENTITY_INSERT [dbo].[BANGDIEM] ON 

INSERT [dbo].[BANGDIEM] ([MASV], [MAMH], [LAN], [NGAYTHI], [DIEM], [MABD], [rowguid]) VALUES (N'001     ', N'AVCB ', 1, CAST(N'2021-07-21 00:00:00.000' AS DateTime), 0, 70004, N'763b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BANGDIEM] ([MASV], [MAMH], [LAN], [NGAYTHI], [DIEM], [MABD], [rowguid]) VALUES (N'002     ', N'AVCB ', 1, CAST(N'2021-07-21 00:00:00.000' AS DateTime), 0, 72005, N'b4396f6b-8af0-eb11-8a77-34cff68b29d6')
SET IDENTITY_INSERT [dbo].[BANGDIEM] OFF
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (1, N'MMTCB', N'A', N'mạng máy tính(compute netword) so với hệ thống tập trung multi-user', N'dễ phát triển hệ thống', N'tăng độ tin cậy', N'tiết kiệm chi phí', N'tất cả đều đúng', N'D', N'TH657   ', N'963a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (3, N'MMTCB', N'A', N'để một máy tính truyền dữ liệu cho một số máy khác trong mạng, ta dùng loại địa chỉ', N'Broadcast', N'Broadband', N'multicast', N'multiple access', N'D', N'TH123   ', N'973a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (4, N'MMTCB', N'A', N'thứ tự phân loại mạng theo chiều dài đường truyền', N'internet, lan, man, wan', N'internet, wan, man, lan', N'lan, wan, man, internet', N'man, lan, wan, internet', N'B', N'TH123   ', N'983a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (5, N'MMTCB', N'A', N'mạng man được sử dụng trong phạm vi:', N'quốc gia', N'lục địa', N'khu phố', N'thành phố', N'D', N'TH123   ', N'993a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (6, N'MMTCB', N'A', N'thuật ngữ man được viết tắt bởi:', N'middle area network', N'metropolitan area network', N'medium area network', N'multiple access network', N'D', N'TH123   ', N'9a3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (7, N'MMTCB', N'A', N'mạng man không kết nối theo sơ đồ:', N'bus', N'ring', N'star', N'tree', N'D', N'TH123   ', N'9b3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (8, N'MMTCB', N'A', N'kiến trúc mạng (network architechture) là:', N'tập các chức năng trong mạng', N'tập các cấp và các protocol trong mỗi cấp', N'tập các dịch vụ trong mạng', N'tập các protocol trong mạng', N'B', N'TH123   ', N'9c3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (9, N'MMTCB', N'A', N'thuật ngữ nào không cùng nhóm:', N'simplex', N'multiplex', N'half duplex', N'full duplex', N'B', N'TH123   ', N'9d3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (10, N'MMTCB', N'A', N'loại dịch vụ nào có thể nhận dữ liệu không đúng thứ tự khi truyền', N'point to point', N'có kết nối', N'không kết nối', N'broadcast', N'C', N'TH123   ', N'9e3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (11, N'MMTCB', N'A', N'dịch vụ không xác nhận (unconfirmed) chỉ sử dụng 2 phép toán cơ bản:', N'response and confirm', N'confirm and request', N'request and indication', N'indication and response', N'C', N'TH123   ', N'9f3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (12, N'MMTCB', N'A', N'Chọn câu sai trong các nguyên lý phân cấp của mô hình OSI', N'Mỗi cấp thực hiện 1 chức năng rõ ràng', N'Mỗi cấp được chọn sao cho thông tin trao đổi giữa các cấp tối thiểu', N'Mỗi cấp được tạo ra ứng với 1 mức trừu tượng hóa', N'Mỗi cấp phải cung cấp cùng 1 kiểu địa chỉ và dịch vụ', N'D', N'TH123   ', N'a03a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (13, N'MMTCB', N'A', N'Chức năng của cấp vật lý(physical)', N'Qui định truyền 1 hay 2 chiều', N'Quản lý lỗi sai', N'Xác định thời gian truyền 1 bit dữ liệu', N'Quản lý địa chỉ vật lý', N'C', N'TH123   ', N'a13a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (14, N'MMTCB', N'A', N'Chức năng câp liên kết dữ liệu (data link)', N'Quản lý lỗi sai', N'Mã hóa dữ liệu', N'Tìm đường đi cho dữ liệu', N'Chọn kênh truyền', N'A', N'TH123   ', N'a23a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (15, N'MMTCB', N'A', N'Chức năng cấp mạng (network)', N'Quản lý lưu lượng đường truyền', N'Điều khiển hoạt động subnet', N'Nén dữ liệu', N'Chọn điện áp trên kênh truyền', N'B', N'TH123   ', N'a33a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (16, N'MMTCB', N'A', N'Chức năng cấp vận tải (transport) ', N'Quản lý địa chỉ mạng', N'Chuyển đổi các dạng frame khác nhau', N'Thiết lập và hủy bỏ dữ liệu', N'Mã hóa và giải mã dữ liệu', N'C', N'TH123   ', N'a43a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (17, N'MMTCB', N'A', N'Cáp xoắn đôi trong mạng LAN dùng đầu nối', N'AUI', N'BNC', N'RJ11', N'RJ45', N'D', N'TH123   ', N'a53a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (18, N'MMTCB', N'A', N'T-connector dùng trong loại cáp', N'10Base-2', N'10Base-5', N'10Base-T', N'10Base-F', N'A', N'TH123   ', N'a63a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (19, N'MMTCB', N'A', N'chọn câu sai trong các nguyên lý phân cấp của mô hình osi', N'mỗi cấp thực hiện 1 chức năng rõ ràng', N'mỗi cấp được chọn sao cho thông tin trao đổi giữa các cấp tối thiểu', N'mỗi cấp được tạo ra ứng với 1 mức trừu tượng hóa', N'mỗi cấp phải cung cấp cùng một kiểu địa chỉ và dịch vụ', N'D', N'TH123   ', N'a73a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (20, N'AVCB ', N'A', N'The publishers suggested that the envelopes be sent to ...... by courier so that the film can be developed as soon as possible', N'they', N'their', N'theirs', N'them', N'D', N'TH234   ', N'a83a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (21, N'AVCB ', N'A', N'Board members ..... carefully define their goals and objectives for the agency before the monthly meeting next week.', N'had', N'should', N'used ', N'have', N'B', N'TH234   ', N'a93a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (22, N'AVCB ', N'A', N'For business relations to continue between our two firms, satisfactory agreement must be ...... reached and signer', N'yet', N'both', N'either ', N'as well as', N'C', N'TH234   ', N'aa3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (23, N'AVCB ', N'A', N'The corporation, which underwent a major restructing seven years ago, has been growing steadily ......five years', N'for', N'on', N'from', N'since', N'A', N'TH234   ', N'ab3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (24, N'AVCB ', N'A', N'Making advance arrangements for audiovisual equipment is....... recommended for all seminars.', N'sternly', N'strikingly', N'stringently', N'strongly', N'A', N'TH234   ', N'ac3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (25, N'AVCB ', N'A', N'Two assistants will be required to ...... reporter''s names when they arrive at the press conference', N'remark', N'check', N'notify', N'ensure', N'B', N'TH234   ', N'ad3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (26, N'AVCB ', N'A', N'The present government has an excellent ......to increase exports', N'popularity', N'regularity', N'celebrity', N'opportunity', N'D', N'TH234   ', N'ae3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (27, N'AVCB ', N'A', N'While you are in the building, please wear your identification badge at all times so that you are ....... as a company employee.', N'recognize', N'recognizing', N'recognizable', N'recognizably', N'C', N'TH234   ', N'af3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (28, N'AVCB ', N'A', N'Our studies show that increases in worker productivity have not been adequately .......rewarded by significant increases in ......', N'compensation', N'commodity', N'compilation', N'complacency', N'B', N'TH234   ', N'b03a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (29, N'AVCB ', N'A', N'Conservatives predict that government finaces will remain...... during the period of the investigation', N'authoritative', N'summarized', N'examined', N'stable', N'D', N'TH234   ', N'b13a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (30, N'AVCB ', N'B', N'Battery-operated reading lamps......very well right now', N'sale', N'sold', N'are selling', N'were sold', N'C', N'TH234   ', N'b23a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (31, N'AVCB ', N'B', N'In order to place a call outside the office, you have to .......nine first. ', N'tip', N'make', N'dial', N'number', N'D', N'TH234   ', N'b33a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (32, N'AVCB ', N'B', N'We are pleased to inform...... that the missing order has been found.', N'you', N'your', N'yours', N'yourseld', N'A', N'TH234   ', N'b43a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (33, N'AVCB ', N'B', N'Unfortunately, neither Mr.Sachs....... Ms Flynn will be able to attend the awards banquet this evening', N'but', N'and', N' nor', N'either', N'C', N'TH234   ', N'b53a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (34, N'AVCB ', N'B', N'According to the manufacturer, the new generatir is capable of....... the amount of power consumed by our facility by nearly ten percent.', N'reduced', N'reducing', N'reduce', N'reduces', N'B', N'TH234   ', N'b63a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (35, N'AVCB ', N'B', N'After the main course, choose from our wide....... of homemade deserts', N'varied', N'various', N'vary', N'variety', N'D', N'TH234   ', N'b73a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (36, N'AVCB ', N'B', N'One of the most frequent complaints among airline passengers is that there is not ...... legroom', N'enough', N'many', N'very', N'plenty', N'A', N'TH234   ', N'b83a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (37, N'AVCB ', N'B', N'Faculty members are planning to..... a party in honor of Dr.Walker, who will retire at the end of the semester', N'carry', N'do', N'hold', N'take', N'D', N'TH234   ', N'b93a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (38, N'AVCB ', N'B', N'Many employees seem more ....... now about how to use the new telephone system than they did before they attended the workshop', N'confusion', N'confuse', N'confused', N'confusing', N'C', N'TH234   ', N'ba3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (39, N'AVCB ', N'B', N'.........our production figures improve in the near future, we foresee having to hire more people between now and July', N'During', N'Only', N'Unless', N'Because', N'D', N'TH234   ', N'bb3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (40, N'AVCB ', N'C', N'Though their performance was relatively unpolished, the actors held the audience''s ........for the duration of the play.', N'attentive', N'attentively', N'attention', N'attentiveness', N'C', N'TH234   ', N'bc3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (41, N'AVCB ', N'C', N'Dr. Abernathy''s donation to Owstion College broke the record for the largest private gift...... give to the campus', N'always', N'rarely', N'once', N'ever', N'C', N'TH234   ', N'bd3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (42, N'AVCB ', N'C', N'Savat Nation Park is ....... by train,bus, charter plane, and rental car.', N'accessible', N'accessing', N'accessibility', N'accesses', N'A', N'TH234   ', N'be3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (43, N'AVCB ', N'C', N'In Piazzo''s lastest architectural project, he hopes to......his flare for blending contemporary and traditional ideals.', N'demonstrate', N'appear', N'valve', N'position', N'A', N'TH234   ', N'bf3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (44, N'AVCB ', N'C', N'Replacing the offic equipment that the company purchased only three years ago seems quite.....', N'waste', N'wasteful', N'wasting', N'wasted', N'C', N'TH234   ', N'c03a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (45, N'AVCB ', N'C', N'On........, employees reach their peak performance level when they have been on the job for at least two years.', N'common', N'standard', N'average', N'general', N'D', N'TH234   ', N'c13a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (46, N'AVCB ', N'C', N'We were........unaware of the problems with the air-conidtioning units in the hotel rooms until this week.', N'complete ', N'completely', N'completed', N'completing', N'D', N'TH234   ', N'c23a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (47, N'AVCB ', N'C', N'If you send in an order ....... mail, we recommend that you phone our sales division directly to confirm the order.', N'near', N'by', N'for', N'on', N'A', N'TH234   ', N'c33a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (48, N'AVCB ', N'C', N'A recent global survey suggests.......... demand for aluminum and tin will remain at its current level for the next five to ten years.', N'which', N'it ', N'that', N'both', N'C', N'TH234   ', N'c43a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (49, N'AVCB ', N'C', N'Rates for the use of recreational facilities do not include ta and are subject to change without.........', N'signal', N'cash', N'report', N'notice', N'A', N'TH234   ', N'c53a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (50, N'AVCB ', N'A', N'Aswering telephone calls is the..... of an operator', N'responsible', N'responsibly', N'responsive', N'responsibility', N'D', N'TH234   ', N'c63a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (51, N'AVCB ', N'A', N'A free watch will be provided with every purchase of $20.00 or more a ........ period of time', N'limit', N'limits', N'limited', N'limiting', N'C', N'TH234   ', N'c73a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (52, N'AVCB ', N'A', N'The president of the corporation has .......arrived in Copenhagen and will meet with the Minister of Trade on Monday morning', N'still', N'yet', N'already', N'soon', N'C', N'TH234   ', N'c83a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (53, N'AVCB ', N'A', N'Because we value your business, we have .......for card members like you to receive one thousand  dollars of complimentary life insurance', N'arrange', N'arranged', N'arranges', N'arranging', N'B', N'TH234   ', N'c93a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (54, N'AVCB ', N'A', N'Employees are........that due to the new government regulations. there is to be no smoking in the factory', N'reminded', N'respected', N'remembered', N'reacted', N'A', N'TH234   ', N'ca3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (55, N'AVCB ', N'A', N'MS. Galera gave a long...... in honor of the retiring vice-president', N'speak', N'speaker', N'speaking', N'speech', N'D', N'TH234   ', N'cb3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (56, N'AVCB ', N'A', N'Any person who is........ in volunteering his or her time for the campaign should send this office a letter of intent', N'interest', N'interested', N'interesting', N'interestingly', N'B', N'TH234   ', N'cc3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (57, N'AVCB ', N'A', N'Mr.Gonzales was very concerned.........the upcoming board of directors meeting', N'to', N'about', N'at ', N'upon', N'B', N'TH234   ', N'cd3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (58, N'AVCB ', N'A', N'The customers were told that no ........could be made on weekend nights because the restaurant was too busy', N'delays', N'cuisines', N'reservation', N'violations', N'C', N'TH234   ', N'ce3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (59, N'AVCB ', N'A', N'The sales representive''s presentation was difficult to understand ........ he spoke very quickly', N'because', N'althought', N'so that', N'than', N'A', N'TH234   ', N'cf3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (60, N'AVCB ', N'B', N'It has been predicted that an.......weak dollar will stimulate tourism in the United States', N'increased', N'increasingly', N'increases', N'increase', N'B', N'TH234   ', N'd03a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (61, N'AVCB ', N'B', N'The firm is not liable for damage resulting from circumstances.........its control.', N'beyond', N'above', N'inside', N'around', N'A', N'TH234   ', N'd13a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (62, N'AVCB ', N'B', N'Because of.......weather conditions, California has an advantage in the production of fruits and vegetables', N'favorite', N'favor', N'favorable', N'favorably', N'C', N'TH234   ', N'd23a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (63, N'AVCB ', N'B', N'On international shipments, all duties and taxes are paid by the..........', N'recipient', N'receiving', N'receipt', N'receptive', N'A', N'TH234   ', N'd33a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (64, N'AVCB ', N'B', N'Although the textbook gives a definitive answer,wise managers will look for........ own creative solutions', N'them', N'their', N'theirs', N'they', N'B', N'TH234   ', N'd43a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (65, N'AVCB ', N'B', N'Initial ....... regarding the merger of the companies took place yesterday at the Plaza Conference Center.', N'negotiations', N'dedications', N'propositions', N'announcements', N'A', N'TH234   ', N'd53a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (66, N'AVCB ', N'B', N'Please......... photocopies of all relevant docunments to this office ten days prior to your performance review date', N'emerge', N'substantiate', N'adapt', N'submit', N'D', N'TH234   ', N'd63a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (67, N'AVCB ', N'B', N'The auditor''s results for the five year period under study were .........the accountant''s', N'same', N'same as', N'the same', N'the same as', N'D', N'TH234   ', N'd73a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (68, N'AVCB ', N'B', N'.........has the marketing environment been more complex and subject to change', N'Totally', N'Negatively', N'Decidedly', N'Rarely', N'D', N'TH234   ', N'd83a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (69, N'AVCB ', N'B', N'All full-time staff are eligible to participate in the revised health plan, which becomes effective the first ......... the month.', N'of', N'to', N'from', N'for', N'A', N'TH234   ', N'd93a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (70, N'AVCB ', N'C', N'Contracts must be read........ before they are signed.', N'thoroughness', N'more thorough', N'thorough', N'thoroughly', N'D', N'TH234   ', N'da3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (71, N'AVCB ', N'C', N'Passengers should allow for...... travel time to the airport in rush hour traffic', N'addition', N'additive', N'additionally', N'additional', N'D', N'TH234   ', N'db3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (72, N'AVCB ', N'C', N'This fiscal year, the engineering team has worked well together on all phases ofproject.........', N'development', N'developed', N'develops', N'developer', N'A', N'TH234   ', N'dc3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (73, N'AVCB ', N'C', N'Mr.Dupont had no ....... how long it would take to drive downtown', N'knowledge', N'thought', N'idea', N'willingness', N'C', N'TH234   ', N'dd3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (74, N'AVCB ', N'C', N'Small company stocks usually benefit..........the so called January effect that cause the price of these stocks to rise between November and January', N'unless', N'from', N'to ', N'since', N'B', N'TH234   ', N'de3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (75, N'AVCB ', N'C', N'It has been suggested that employees ........to work in their current positions until the quarterly review is finished.', N'continuity', N'continue', N'continuing', N'continuous', N'B', N'TH234   ', N'df3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (76, N'AVCB ', N'C', N'It is admirable that Ms.Jin wishes to handle all transactions by........, but it might be better if several people shared the responsibility', N'she', N'herself', N'her', N'hers', N'B', N'TH234   ', N'e03a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (77, N'AVCB ', N'C', N'This new highway construction project will help the company.........', N'diversity', N'clarify', N'intensify', N'modify', N'A', N'TH234   ', N'e13a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (78, N'AVCB ', N'C', N'Ms.Patel has handed in an ........business plan to the director', N'anxious', N'evident', N'eager', N'outstanding', N'D', N'TH234   ', N'e23a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (79, N'AVCB ', N'C', N'Recent changes in heating oil costs have affected..........production of turniture', N'local', N'locality', N'locally', N'location', N'A', N'TH234   ', N'e33a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (80, N'MMTCB', N'A', N'Termiator là linh kiện dùng trong loại cáp mạng', N'Cáp quang', N'UTP và STP ', N'Xoắn đôi', N'Đồng trục', N'D', N'TH123   ', N'e43a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (81, N'MMTCB', N'A', N'Mạng không dây dùng loại sóng nào không bị ảnh hưởng bởi khoảng cách địa lý', N'Sóng radio', N'Sống hồng ngoại', N'Sóng viba', N'Song cực ngắn', N'A', N'TH123   ', N'e53a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (82, N'MMTCB', N'A', N'Đường truyền E1 gồm 32 kênh, trong đó sử dụng cho dữ liệu là:', N'32 kênh', N'31 kênh', N'30 kênh', N'24 kênh', N'C', N'TH123   ', N'e63a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (83, N'MMTCB', N'A', N'Mạng máy tính thường sử dụng loại chuyển mach', N'Gói (packet switch)', N'Kênh (Circuit switch)', N'Thông báo(message switch)', N'Tất cả đều đúng', N'A', N'TH123   ', N'e73a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (84, N'MMTCB', N'A', N'Cáp UTP hỗ trợ tôc độ truyền 100MBps là loại', N'Cat 3', N'Cat 4', N'Cat 5', N'Cat 6', N'C', N'TH123   ', N'e83a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (85, N'MMTCB', N'A', N'Thiết bị nào làm việc trong cấp vật lý (physical) ', N'Terminator', N'Hub', N'Repeater', N'Tất cả đều đúng', N'D', N'TH123   ', N'e93a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (86, N'MMTCB', N'A', N'Phương pháp dồn kênh phân chia tần số gọi là', N'FDM', N'WDM', N'TDM', N'CSMA', N'A', N'TH123   ', N'ea3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (87, N'MMTCB', N'A', N'Dịch vụ nào không sử dụng trong cấp data link', N'Xác nhận, có kết nối', N'Xác nhận, không kết nôi', N'Không xác nhận, có kết nối', N'Không xác nhận, không kết nối', N'C', N'TH123   ', N'eb3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (88, N'MMTCB', N'A', N'Nguyên nhân gây sai sót khi gửi/nhận dữ liệu trên mạng', N'Mất đồng bộ trong khi truyền', N'Nhiễu từ môi trường', N'Lỗi phần cứng hoặc phần mềm', N'Tất cả đều đúng ', N'D', N'TH123   ', N'ec3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (89, N'MMTCB', N'A', N'Để tránh sai sót khi truyền dữ liệu trong cấp data link', N'Đánh số thứ tự frame', N'Quản lý dữ liệu theo frame', N'Dùng vùng checksum', N'Tất cả đều đúng', N'D', N'TH123   ', N'ed3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (90, N'MMTCB', N'A', N'Quản lý lưu lượng đường truyền là chức năng của cấp', N'Presentation', N'Network', N'Data link', N'Physical', N'C', N'TH123   ', N'ee3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (91, N'MMTCB', N'A', N'Hoạt động của protocol Stop and Wait', N'Chờ một khoảng thời gian time-out rồi gửi tiếp frame kế', N'Chờ 1 khoảng thời gian time-out rồi gửi lại frame trước', N'Chờ nhận được ACK của frame trước mới gửi tiếp frame kế', N'Không chờ mà gửi liên tiếp các frame kế nhau', N'C', N'TH123   ', N'ef3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (92, N'MMTCB', N'A', N'Protocol nào tạo frame bằng phương pháp chèn kí tự', N'ADCCP', N'HDLC', N'SDLC', N'PPP', N'D', N'TH123   ', N'f03a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (93, N'MMTCB', N'A', N'Phương pháp nào được dủng trong việc phát hiện lỗi', N'Timer', N'Ack', N'Checksum', N'Tất cả đều đúng', N'C', N'TH123   ', N'f13a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (94, N'MMTCB', N'A', N'Kiểm soát lưu lượng (flow control) có nghĩa là', N'Thay đổi thứ tự truyền frame', N'Điều tiết tốc độ truyền frame', N'Thay đổi thời gian chờ time-out', N'Điều chỉnh kích thước frame', N'B', N'TH123   ', N'f23a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (95, N'MMTCB', N'A', N'Khả năng nhận biết tình trạng đường truyền ( carrier sence) là', N'Xác định đường truyền tốt hay xấu', N'Có kết nối được hay không', N'Nhận biết có xung đột hay không', N'Đường truyền đang rảnh hay bận', N'C', N'TH123   ', N'f33a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (96, N'MMTCB', N'A', N'Mạng nào không có khả năng nhận biết tình trạng đường truyền (carrier sence)', N'ALOHA', N'CSMA', N'CSMA/CD', N'Tất cả đều đúng ', N'A', N'TH123   ', N'f43a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (97, N'MMTCB', N'A', N'Mạng nào có khả năng nhận biết xung đột (collision)', N'ALOHA', N'CSMA', N'CSMA/CD', N'Tất cả đều đúng', N'D', N'TH123   ', N'f53a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (98, N'MMTCB', N'A', N'Chuẩn mạng nào có khả năng pkhát hiện xung đột (collision) trong khi truyền', N'1-persistent CSMA', N'p-persistent CSMA', N'Non-persistent CSMA', N'CSMA/CD', N'D', N'TH123   ', N'f63a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (99, N'MMTCB', N'A', N'Loại mạng cục bộ nào dùng chuẩn CSMA/CD', N'Token-ring', N'Token-bus', N'Ethernet', N'ArcNet', N'C', N'TH123   ', N'f73a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (100, N'MMTCB', N'A', N'Mạng Ethernet được IEEE đưa vào chuẩn', N'IEEE 802.2', N'IEEE 802.3', N'IEEE 802.4', N'IEEE 802.5', N'B', N'TH123   ', N'f83a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (101, N'MMTCB', N'A', N'Chuẩn nào không dùng trong mạng cục bộ (LAN )', N'IEEE 802.3', N'IEEE 802.4', N'IEEE 802.5', N'IEEE 802.6', N'D', N'TH123   ', N'f93a55a9-67eb-eb11-8a76-34cff68b29d6')
GO
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (102, N'MMTCB', N'A', N'Loại mạng nào dùng 1 máy tính làm Monitor để bảo trì mạng', N'Ethernet', N'Token-ring', N'Token-bus', N'Tất cả đều sai', N'B', N'TH123   ', N'fa3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (103, N'MMTCB', N'A', N'Loại mạng nào không có độ ưu tiên', N'Ethernet', N'Token-ring', N'Token-bus', N'Tất cả đều sai', N'D', N'TH123   ', N'fb3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (104, N'MMTCB', N'A', N'Loại mạng nào dùng 2 loại frame khác nhau trên đường truyền', N'Token-ring', N'Token-bus', N'Ethernet', N'Tất cả đều sai', N'A', N'TH123   ', N'fc3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (105, N'MMTCB', N'A', N'Vùng dữ liệu trong mạng Ethernet chứa tối đa', N'185 bytes', N'1500 bytes', N'8182 bytes', N'Không giới hạn', N'B', N'TH123   ', N'fd3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (106, N'MMTCB', N'A', N'Chọn câu sai:" Cầu nối (bridge) có thể kết nối các mạng có...."', N'Chiều dài frame khác nhau', N'Cấu trúc frame khác nhau', N'Tốc độ truyền khác nhau', N'Chuẩn khác nhau', N'A', N'TH123   ', N'fe3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (107, N'MMTCB', N'A', N'Mạng nào có tốc độ truyền lớn hơn 100Mbps', N'Fast Ethernet', N'Gigabit Ethernet', N'Ethernet', N'Tất cả đều đúng', N'B', N'TH123   ', N'ff3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (108, N'MMTCB', N'A', N'Mạng Ethernet sử dụng được loại cáp', N'Cáp quang', N'Xoắn đôi', N'Đồng trục', N'Tất cả đều đúgn', N'D', N'TH123   ', N'003b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (109, N'MMTCB', N'A', N'Khoảng cách đường truyền tối đa mạng FDDI có thể đạt', N'1Km', N'10Km', N'100Km', N'1000Km', N'C', N'TH123   ', N'013b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (110, N'MMTCB', N'A', N'Cấp network truyền nhận theo kiểu end-to-end vì nó quản lý dữ liệu', N'Giữa 2 đầu subnet', N'Giữa 2 máy tính trong mạng', N'Giữa 2 thiết bị trên đường truyền', N'Giữa 2 đầu đường truyền', N'A', N'TH123   ', N'023b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (111, N'MMTCB', N'A', N'Kiểu mạch ảo(virtual circuit) được dùng trong loại dịch vụ mạng', N'Có kết nối', N'Không kết nối', N'Truyền 1 chiều', N'Truyền 2 chiều', N'A', N'TH123   ', N'033b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (112, N'MMTCB', N'A', N'Kiểu datagram trong cấp network', N'Chỉ tìm đường 1 lần khi tạo kết nối', N'Phải tìm đường riêng cho từng packet', N'THông tin có sẵn trong packet, không cần tìm đường', N'Thông tin có sẵn trong router , không cần tìm đường', N'B', N'TH123   ', N'043b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (113, N'MMTCB', N'A', N'Kiểm soát tắc nghẽn (congestion) là nhiệm vụ của cấp', N'Physical', N'Transport', N'Data link', N'Network', N'D', N'TH123   ', N'053b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (114, N'MMTCB', N'A', N'Nguyên nhân dẫn đến tắt nghẻn (congestion) trên mạng', N'Tốc độ xử lý của router chậm', N'Buffers trong router nhỏ', N'Router có nhiều đường vào nhưng ít đường ra', N'Tất cả đều đúng', N'D', N'TH123   ', N'063b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (115, N'MMTCB', N'A', N'Cấp appliation trong mô hình TCP/IP tương đương với cấp nào trong mô hình OSI', N'Session', N'Application', N'Presentation', N'Tất cả đều đúng', N'D', N'TH123   ', N'073b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (116, N'MMTCB', N'A', N'Cấp nào trong mô hình mạng OSI tương đương với cấp Internet trong mô hình TCP/IP ', N'Network', N'Transport', N'Physical', N'Data link', N'A', N'TH123   ', N'083b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (117, N'MMTCB', N'A', N'Chất lượng dịch vụ mạng không được đánh giá trên chỉ tiêu nào?', N'Thời gian thiết lập kết nối ngắn', N'Tỉ lệ sai sót rất nhỏ', N'Tốc độ đường truyền cao', N'Khả năng phục hồi khi có sự cố', N'A', N'TH123   ', N'093b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (118, N'MMTCB', N'A', N'Kỹ thuật Multiplexing được dùng khi', N'Có nhiều kênh truyền hơn đường truyền', N'Có nhiều đường truyền hơn kênh truyền', N'Truyền dữ liệu số trên mạng điện thoại', N'Truyền dữ liệu tương tự trên mạng điện thọai', N'A', N'TH123   ', N'0a3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (119, N'MMTCB', N'A', N'Dịch vụ truyền Email sử dụng protocol nào?', N'HTTP', N'NNTP', N'SMTP', N'FTP', N'C', N'TH123   ', N'0b3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (120, N'MMTCB', N'A', N'Địa chỉ IP lớp B nằm trong phạm vi nào', N'192.0.0.0 - 223.0.0.0', N'127.0.0.0 - 191.0.0.0', N'128.0.0.0 - 191.0.0.0 ', N'1.0.0.0 - 126.0.0.0', N'C', N'TH123   ', N'0c3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (121, N'MMTCB', N'A', N'Subnet Mask nào sau đây chỉ cho tối đa 2 địa chỉ host', N'255.255.255.252', N'255.255.255.254', N'255.255.255.248', N'255.255.255.240', N'A', N'TH123   ', N'0d3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (122, N'MMTCB', N'A', N'Thành phần nào không thuộc socket', N'Port', N'Địa chỉ IP', N'Địa chỉ cấp MAC', N'Protocol cấp Transport', N'C', N'TH123   ', N'0e3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (123, N'MMTCB', N'A', N'Mục đích của Subnet Mask trong địa chỉ IP là', N'Xác định host của địa chỉ IP', N'Xác định vùng network của địa chỉ IP', N'Lấy các bit trong vùng subnet làm địa chỉ host', N'Lấy các bit trong vùng địa chỉ host làm subnet', N'A', N'TH123   ', N'0f3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (124, N'MMTCB', N'A', N'Bước đầu tiên cần thực hiện để truyền dữ liệu theo ALOHA là', N'Chờ 1 thời gian ngẫu nhiên', N'Gửi tín hiệu tạo kết nối', N'Kiểm tra tình trạng đường truyền', N'Lập tức truyền dữ liệu', N'D', N'TH123   ', N'103b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (125, N'MMTCB', N'A', N'Cầu nối trong suốt hoạt động trong cấp nào', N'Data link', N'Physical', N'Network', N'Transport', N'A', N'TH123   ', N'113b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (126, N'MMTCB', N'A', N'Tốc độ của đường truyền T1 là:', N'2048 Mbps', N'1544 Mbps', N'155 Mbps', N'56 Kbps', N'B', N'TH123   ', N'123b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (127, N'MMTCB', N'A', N'Khi một dịch vụ trả lời ACK cho biết dữ liệu đã nhận được, đó là', N'Dịch vụ có xác nhận', N'Dịch vụ không xác nhận', N'Dịch vụ có kết nối', N'Dịch vụ không kết nối', N'A', N'TH123   ', N'133b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (128, N'MMTCB', N'A', N'Loại frame nào được sử dụng trong mạng Token-ring', N'Monitor', N'Token', N'Data', N'Token và Data', N'D', N'TH123   ', N'143b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (129, N'MMTCB', N'A', N'Thuật ngữ OSI là viết tắt bởi', N'Organization for Standard Institude', N'Organization for Standard Internet', N'Open Standard Institude', N'Open System Interconnection', N'D', N'TH123   ', N'153b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (130, N'MMTCB', N'A', N'Trong mạng Token-ting, khi 1 máy nhận được Token', N'Nó phải truyền cho máy kế trong vòng', N'Nó được quyền truyền dữ liệu', N'Nó được quyền giữ lại Token', N'Tất cả đều sai', N'B', N'TH123   ', N'163b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (131, N'MMTCB', N'A', N'Trong mạng cục bộ, để xác định 1 máy trong mạng ta dùng địa chỉ', N'MAC', N'Socket', N'Domain', N'Port', N'A', N'TH123   ', N'173b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (132, N'MMTCB', N'A', N'Thứ tự các cấp trong mô hình OSI', N'Application,Session,Transport,Physical', N'Application, Transport, Network, Physical', N'Application, Presentation,Session,Network,Transport,Data link,Physical', N'Application,Presentation,Session,Transport,Network,Data link,Physical', N'D', N'TH123   ', N'183b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (133, N'MMTCB', N'A', N'Cấp vật lý (physical) không quản lý', N'Mức điện áp', N'Địa chỉ vật lý', N'Mạch giao tiếp vật lý', N'Truyền các bit dữ liêu', N'B', N'TH123   ', N'193b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (134, N'MMTCB', N'A', N'TCP sử dụng loại dịch vụ', N'Có kết nối, độ tin cậy cao', N'Có kết nối, độ tin cậy thấp', N'Không kết nối, độ tin cậy cao', N'Không kết nối, độ tin cậy thấp', N'A', N'TH123   ', N'1a3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (135, N'MMTCB', N'A', N'Địa chỉ IP bao gồm', N'Địa chỉ Network và địa chỉ host', N'Địa chỉ physical và địa chỉ logical', N'Địa chỉ cấp MAC và và địa chỉ LLC', N'Địa chỉ hardware và địa chỉ software', N'A', N'TH123   ', N'1b3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (136, N'MMTCB', N'A', N'Chức năng cấp mạng (network) là', N'Mã hóa và định dạng dữ liệu', N'Tìm đường và kiểm soát tắc nghẽn', N'Truy cập môi trường mạng', N'Kiểm soát lỗi và kiểm soát lưu lượng', N'B', N'TH123   ', N'1c3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (137, N'MMTCB', N'A', N'Mạng CSMA/CD làm gì', N'Truyền Token trên mạng hình sao', N'Truyền Token trên mạng dạng Bus', N'Chia packet ra thành từng frame nhỏ và truỵền đi trên mạng', N'Truy cập đường truyền và truyền lại dữ liệu nếu xảy ra đụng độ', N'D', N'TH123   ', N'1d3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (138, N'MMTCB', N'A', N'Tiền thân của mạng Internet là', N'Intranet', N'Ethernet', N'Arpanet', N'Token-bus', N'C', N'TH123   ', N'1e3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (139, N'MMTCB', N'A', N'Khi 1 cầu nối ( bridge) nhận được 1 framechưa biết thông tin về địa chỉ máy nhận, nó sẽ', N'Xóa bỏ frame này', N'Gửi trả lại máy gốc', N'Gửi đến mọi ngõ ra còn lại', N'Giảm thời gian sống của frame đi 1 đơn vị và gửi đến mọi ngõ ra còn lại', N'C', N'TH123   ', N'1f3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (140, N'MMTCB', N'A', N'Chức năng của cấp Network là', N'Tìm đường', N'Mã hóa dữ liệu', N'Tạo địa chỉ vật lý', N'Kiểm soát lưu lượng', N'A', N'TH123   ', N'203b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (141, N'MMTCB', N'B', N'Sự khác nhau giữa địa chỉ cấp Data link và Network là', N'Địa chỉ cấp Data link có kích thước nhỏ hơn địa chỉ cấp Network', N'Địa chỉ cấp Data link là đia chỉ Physic, địa chỉ cấp Network là địa chỉ Logic', N'Địa chỉ cấp Data Link là địa chỉ Logic, địa chỉ câp Network là địa chỉ Physic', N'Địa chỉ Data link cấu hình theo mạng, địa chỉ cấp Network xác định theo IEEE', N'B', N'TH123   ', N'213b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (142, N'MMTCB', N'B', N'Kỹ thuật nào không sử dụng được trong việc kiểm soát lưu lượng(flow control)', N'Ack', N'Buffer', N'Windowing', N'Multiplexing', N'D', N'TH123   ', N'223b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (143, N'MMTCB', N'B', N'Cấp cao nhất trong mô hình mạng OSI là', N'Transport', N'Physical', N'Network', N'Application', N'D', N'TH123   ', N'233b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (144, N'MMTCB', N'B', N'Tại sao mạng máy tình dùng mô hình phân cấp', N'Để mọi người sử dụng cùng 1 ứng dụng mạng', N'Để phân biệt giữa chuẩn mạng và ứng dụng mạng', N'Giảm độ phức tạp trong việc thiết kế và cài đặt', N'Các cấp khác không cần sửa đổi khi thay đổi 1 cấp mạng', N'D', N'TH123   ', N'243b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (145, N'MMTCB', N'B', N'Router làm gì để giảm tăc nghẽn (congestion)', N'Nén dữ liệu', N'Lọc bớt dữ liệu theo địa chỉ vật lý', N'Lọc bớt dữ liệu theo địa chỉ logic', N'Cấm truyền dữ liệu broadcasr', N'D', N'TH123   ', N'253b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (146, N'MMTCB', N'B', N'Byte đầu của 1 IP có giá trị 222, địa chỉ này thuộc lớp địa chỉ nào', N'Lớp A', N'Lớp B', N'Lớp C', N'Lớp D', N'C', N'TH123   ', N'263b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (147, N'MMTCB', N'B', N'Chọn câu đúng đối với switch của mạng LAN', N'Là 1 cầu nối tốc độ cao', N'Nhận data từ 1 cổng và xuất ra mọi cổng còn lại', N'Nhận data từ 1 cổng và xuất ra  cổng đích tùy theo địa chỉ cấp IP', N'Nhận data từ 1 cổng và xuất ra 1 cổng đích tùy theo địa chỉ cấp MAC', N'D', N'TH123   ', N'273b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (148, N'MMTCB', N'B', N'Thuật ngữ nào cho biết loại mạng chỉ truyền được  chiều tại 1 thời điểm', N'Half duplex', N'Full duplex', N'Simplex', N'Monoplex', N'A', N'TH123   ', N'283b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (149, N'MMTCB', N'B', N'Protocol nghĩa là', N'Tập các chuẩn truyền dữ liệu', N'Tập các cấp mạng trong mô hình OSI', N'Tập các chức năng của từng cấp trong mạng', N'Tập các qui tắc và cấu trúc dữ liệu để truyền thông giữa các cấp mạng', N'D', N'TH123   ', N'293b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (150, N'MMTCB', N'B', N'Truyền dữ liệu theo kiểu có kết nối không cần thực hiện việc', N'Hủy kết nối', N'Tạo kết nối', N'Truyền dữ liệu', N'Tìm đường cho từng gói tin', N'D', N'TH123   ', N'2a3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (151, N'MMTCB', N'B', N'Byte đầu của địa chỉ IP lớp E nằm trong phạm vi', N'128 - 191', N'192 - 232 ', N'224 - 239 ', N'240 - 247', N'D', N'TH123   ', N'2b3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (152, N'MMTCB', N'B', N'Khi truyền đi chuỗi "VIET NAM" nhưng nhận được chuỗi"MAN TEIV ". Cần phải hiệu chỉnh các protocol trong cấp nào để truyền chính xác', N'Session', N'Transport', N'Application', N'Presentation', N'B', N'TH123   ', N'2c3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (153, N'MMTCB', N'B', N'Tên cáp UTP dùng torng mạng Fast Ethernet là', N'100BaseF', N'100Base2', N'100BaseT', N'100Base5', N'C', N'TH123   ', N'2d3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (154, N'MMTCB', N'B', N'Tốc độ truyền của mạng Ethernet là', N'1 Mbps', N'10 Mbps', N'100 Mbps', N'1000 Mbps', N'B', N'TH123   ', N'2e3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (155, N'MMTCB', N'B', N'Dịch vụ mạng thường được phân chia thành', N'Dịch vụ không kết nối và có kết nối', N'Dich vụ có xác nhận và không xác nhận', N'Dịch vụ có độ tin cậy cao và có độ tin cậy thấp', N'Tất cả đều đúng', N'D', N'TH123   ', N'2f3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (156, N'MMTCB', N'B', N'Đơn vị truyền dữ liệu trong cấp Network gọi là', N'Bit', N'Frame', N'Packet', N'Segment', N'C', N'TH123   ', N'303b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (157, N'MMTCB', N'B', N'Protocol nào trong mạng TCP/IP chuyển đổi địa chỉ vật lý thành địa chỉ IP', N'IP', N'ARP', N'ICMP', N'RARP', N'D', N'TH123   ', N'313b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (158, N'MMTCB', N'B', N'Đầu nới AUI dùng cho loại cáp nào?', N'Đồng trục', N'Xoắn đôi', N'Cáp quang', N'Tất cả đều đúng', N'A', N'TH123   ', N'323b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (159, N'MMTCB', N'B', N'Subnet mask chuẩn của địa chỉ IP lớp B là', N'255.0.0.0', N'255.255.0.0', N'255.255.255.0', N'255.255.255.255', N'B', N'TH123   ', N'333b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (160, N'MMTCB', N'B', N'Lý do nào khiến người ta chọn protocol TCP hơn là UDP', N'Không ACK', N'Dễ sử dụng', N'Độ tin cậy', N'Không kết nối', N'C', N'TH123   ', N'343b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (161, N'MMTCB', N'B', N'Nhược điểm của dịch vụ có kết nối so với không kết nối', N'Độ tin cậy', N'Thứ tự nhận dữ liệu không đúng', N'Đường truyền không thay đổi', N'Đường truyền thay đổi liên tục', N'C', N'TH123   ', N'353b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (162, N'MMTCB', N'B', N'Cấp Data link không thực hiện chức năng nào?', N'Kiểm soát lỗi', N'Địa chỉ vật lý', N'Kiểm soát lưu lượng', N'Thiết lập kết nối', N'D', N'TH123   ', N'363b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (163, N'MMTCB', N'B', N'Cầu nối (bridge)dựa vào thông tin nào để truyền tiếp hoặc hủy bỏ 1 frame', N'Điạ chỉ nguồn', N'Địa chỉ đích', N'Địa chỉ mạng', N'Tất cả đều đúng', N'C', N'TH123   ', N'373b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (164, N'MMTCB', N'B', N'Chuẩn nào sử dụng trong cấp presentation?', N'UTP và STP', N'SMTP và HTTP', N'ASCII và EBCDIC', N'TCP và UDP', N'C', N'TH123   ', N'383b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (165, N'MMTCB', N'B', N'Đơn vị truyền dữ liệu giữa các cấp trong mạng theo thứ tự', N'bit,frame,packet,data', N'bit,packet,frame,data', N'data,frame,packet,bit', N'data,bit,packet,frame', N'A', N'TH123   ', N'393b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (166, N'MMTCB', N'B', N'Mạng Ethernet do cơ quan nào phát minh', N'ANSI', N'ISO', N'IEEE', N'XEROX', N'D', N'TH123   ', N'3a3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (167, N'MMTCB', N'B', N'Chiều dài loại cáp nào tối đa 100 m? ', N'10Base2', N'10Base5', N'10BaseT', N'10BaseF', N'C', N'TH123   ', N'3b3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (168, N'MMTCB', N'B', N'Địa chỉ IP 100.150.200.250 có nghĩa là', N'Địa chỉ network 100, địa chỉ host 150.200.250', N'Địa chỉ network 100.150, địa chỉ host 200.250', N'Địa chỉ network 100.150.200, địa chỉ host 250', N'Tất cả đều sai', N'D', N'TH123   ', N'3c3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (169, N'MMTCB', N'B', N'Switching hun khác hub thông thường ở chỗ nó làm', N'Giảm collision trên mạng', N'Tăng collision trên mạng', N'Giảm congestion trên mạng', N'Tăng congestion trên mạng', N'A', N'TH123   ', N'3d3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (170, N'MMTCB', N'B', N'Loại cáp nào chỉ truyền dữ liệu 1 chiều', N'Cáp quang', N'Xoắn đôi', N'Đồng trục', N'Tất cả đều đúng', N'A', N'TH123   ', N'3e3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (171, N'MMTCB', N'B', N'Thiết bị Modem dùng để', N'Tách và ghép tín hiệu', N'Nén và gải nén tín hiệu', N'Mã hóa và giải mã tín hiệu', N'Điều chế và giải điều chế tín hiệu', N'D', N'TH123   ', N'3f3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (172, N'MMTCB', N'B', N'Việc cấp phát kênh truyền áp dụng cho loại mạng', N'Peer to peer', N'Point to point', N'Broadcast', N'Multiple Access', N'C', N'TH123   ', N'403b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (173, N'MMTCB', N'B', N'Mạng nào dùng phương pháp mã hóa Manchester Encoding', N'Ethernet', N'Token-ring', N'Token-bus', N'Tất cả đều đúng ', N'D', N'TH123   ', N'413b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (174, N'MMTCB', N'B', N'Phương pháp tìm đường có tính đến thời gian trễ', N'Tìm đường theo chiều sâu', N'Tìm đường theo chiều rộng', N'Tìm đường theo vector khoảng cách', N'Tìm đường theo trạng thái đường truyền', N'D', N'TH123   ', N'423b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (175, N'MMTCB', N'B', N'Chuẩn mạng nào khi có dữ liệu không truyền ngay mà chờ 1 thời gian ngẫu nhiên?', N'1-presistent CSMA', N'p-presistent CSMA', N'Non-presistent CSMA', N'CSMA/CD', N'C', N'TH123   ', N'433b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (176, N'MMTCB', N'B', N'Phương pháp chèn bit (bit stuffing) được dùng để', N'Phân biệt đầu và cuối frame', N'Bổ sung cho đủ kích thước frame tối thiểu', N'Phân cách nhiều bit 0 bằng bit 1', N'Biến đổi dạng dữ liệu 8 bit ra 16 bit', N'A', N'TH123   ', N'443b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (177, N'MMTCB', N'B', N'Để chống nhiễu trên đường truyền tốt nhất, nên dùng loại cáp:', N'Xoắn đôi', N'Đồng trục', N'Cáp quang', N'Mạng không dây', N'C', N'TH123   ', N'453b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (178, N'MMTCB', N'B', N'Phần mềm gửi/nhận thư điện tử thuộc cấp nào trong mô hình OSI', N'Data link', N'Network', N'Application', N'Presentation', N'C', N'TH123   ', N'463b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (179, N'MMTCB', N'B', N'Chức năng của thiết bị Hub trong mạng LAN', N'Mã hóa tín hiệu', N'Triệt tiêu tín hiệu', N'Phân chia tín hiệu', N'Điều chế tín hiếu', N'C', N'TH123   ', N'473b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (180, N'MMTCB', N'B', N'Switch là thiết bị mạng làm việc tương tự như', N'Hub', N'Repeater', N'Router', N'Bridge', N'D', N'TH123   ', N'483b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (181, N'MMTCB', N'C', N'Thiết bị nào làm việc trong cấp Network', N'Bridge', N'Repeater', N'Router', N'Gateway', N'C', N'TH123   ', N'493b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (182, N'MMTCB', N'C', N'Thiết bị nào cần có bộ nhớ làm buffer', N'Hub', N'Switch', N'Repeater', N'Router', N'D', N'TH123   ', N'4a3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (183, N'MMTCB', N'C', N'Luật 5-4-3 cho phép tối đa', N'5 segment trong 1 mạng', N'5 repeater trong 1 mạng', N'5 máy tính trong 1 mạng', N'5 máy tính trong 1 segment', N'A', N'TH123   ', N'4b3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (184, N'MMTCB', N'C', N'Thiết bị nào có thể thêm vào mạng LAN mà không sợ vi phạm luật 5-4-3', N'Router', N'Repeater', N'Máy tính', N'Tất cả đều đúng', N'A', N'TH123   ', N'4c3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (185, N'MMTCB', N'C', N'Thêm thiết bị nào vào mạng có thể qui phạm luật 5-4-3', N'Router', N'Repeater', N'Bridge', N'Tất cả đều đúng', N'B', N'TH123   ', N'4d3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (186, N'MMTCB', N'C', N'Mạng nào cóxảy ra xung đột (collision) trên đường truyền', N'Ethernet', N'Token-ring', N'Token-bus', N'Tất cả đều sai', N'A', N'TH123   ', N'4e3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (187, N'MMTCB', N'C', N'Từ "Broad" trong tên cáp 10Broad36 viết tắt bởi', N'Broadcast', N'Broadbase', N'Broadband', N'Broadway', N'C', N'TH123   ', N'4f3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (188, N'MMTCB', N'C', N'Protocol nào sử dụng trong cấp Network', N'IP', N'TCP', N'UDP', N'FTP', N'A', N'TH123   ', N'503b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (189, N'MMTCB', N'C', N'Protocol nào torng cấp Transport cung cấp dịch vụ không kết nối', N'IP', N'TCP', N'UDP', N'FTP', N'C', N'TH123   ', N'513b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (190, N'MMTCB', N'C', N'Protocol nào trong cấp Transport dùng kiểu dịch vụ có kết nối?', N'IP', N'TCP', N'UDP', N'FTP', N'B', N'TH123   ', N'523b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (191, N'MMTCB', N'C', N'Địa chỉ IP được chia làm mấy lớp', N'2', N'3', N'4', N'5', N'D', N'TH123   ', N'533b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (192, N'MMTCB', N'C', N'Chức năng nào không phải của cấp Network', N'Tìm đường', N'Địa chỉ logic', N'Kiểm soát tắc nghẽn', N'Chất lượng dịch vụ', N'B', N'TH123   ', N'543b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (193, N'MMTCB', N'C', N'Phương pháp chèn kí tự dùng để', N'Phân cách các frame', N'Phân biệt dữ liệu và ký tự điều khiển', N'Nhận diện đầu cuối frame', N'Bổ sung cho đủ kich thước frame tối thiểu', N'B', N'TH123   ', N'553b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (194, N'MMTCB', N'C', N'Kỹ thuật truyền nào mã hóa trực tiếp dữ liệu ra đường truyền không cần sóng mang', N'Broadcast', N'Digital', N'Baseband', N'Broadband', N'C', N'TH123   ', N'563b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (195, N'MMTCB', N'C', N'Sóng viba sử dụng băng tần', N'SHF', N'LF và MF', N'UHF và VHF', N'Tất cả đều đúng', N'D', N'TH123   ', N'573b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (196, N'MMTCB', N'C', N'Sóng viba bị ảnh hưởng bời', N'Trời mưa', N'Sấm chớp', N'Giông bão', N'Ánh sáng mặt trời', N'A', N'TH123   ', N'583b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (197, N'MMTCB', N'C', N'Đường dây trung kế trong mạng điện thoại sử dụng', N'Tín hiệu số', N'Kỹ thuật dồn kênh', N'Cáp quang, cáp đồng và viba', N'Tất cả đêu đúng', N'D', N'TH123   ', N'593b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (198, N'MMTCB', N'C', N'Cáp quang dùng công nghệ dồn kênh nào', N'TDM', N'FDM', N'WDM', N'CDMA', N'C', N'TH123   ', N'5a3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (199, N'MMTCB', N'C', N'Nhược điểm của phương pháp chèn ký tự', N'Giảm tốc độ đường truyền', N'Tăng phí tổn đường truyền', N'Mất đồng bộ frame', N'Không nhận diện được frame', N'B', N'TH123   ', N'5b3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (200, N'MMTCB', N'C', N'Mất đồng bộ frame xảy ra đối với phương pháp', N'Chèn bit', N'Đếm ký tự', N'Chèn ký tự', N'Tất cả đều đúng', N'B', N'TH123   ', N'5c3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (201, N'MMTCB', N'C', N'Mạng nào dùng công nghệ Token-bus', N'FDDI', N'CDDI', N'Fast Ethernet', N'100VG-AnyLAN', N'D', N'TH123   ', N'5d3b55a9-67eb-eb11-8a76-34cff68b29d6')
GO
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (202, N'MMTCB', N'C', N'Thiết bị nào tự trao đổi thông tin lẫn nhau để quản lý mạng', N'Hub', N'Bridge', N'Router', N'Repeater', N'C', N'TH123   ', N'5e3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (203, N'MMTCB', N'C', N'Tần số sóng điện từ dùng trong mạng vô tuyến sắp theo thứ tự tăng dần', N'Radio,viba,hồng ngoại', N'Radio,hồng ngoại,viba', N'Hồng ngoại,viba,radio', N'Viba,radio,hồng ngoại', N'A', N'TH123   ', N'5f3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (204, N'MMTCB', N'C', N'Đường dây hạ kế (local loop) trong mạch điện thoại dùng tín hiệu', N'Digital', N'Analog', N'Manchester', N'T1 hoặc E1', N'B', N'TH123   ', N'603b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (205, N'MMTCB', N'C', N'Để tránh nhận trùng dữ liệu người ta dùng phương pháp', N'Đánh số thứ tự các frame', N'Quy định kích thước frame cố định', N'Chờ nhận ACK mới gửi frame kế tiếp', N'So sánh và loại bỏ các frame giống nhau', N'A', N'TH123   ', N'613b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (206, N'MMTCB', N'C', N'Cơ chế Timer dùng để', N'Đo thời gian chơ frame', N'Tránh tình trạng mất frame', N'Chọn thời điểm truyền frame', N'Kiểm soát thòi gian truyền frame', N'A', N'TH123   ', N'623b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (207, N'MMTCB', N'C', N'Cấp nào trong mô hình OSI quan tâm tới topology mạng', N'Transport', N'Network', N'Data link', N'Physical', N'B', N'TH123   ', N'633b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (208, N'MMTCB', N'C', N'Loại mạng nào sử dụng trên WAN', N'Ethernet và Token-bus', N'ISDN và Frame relay', N'Token-ring và FDDI', N'SDLC và HDLC', N'A', N'TH123   ', N'643b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (209, N'MMTCB', N'C', N'Repeater nhiều port là tên gọi của', N'Hub', N'Host', N'Bridge', N'Router', N'A', N'TH123   ', N'653b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (210, N'MMTCB', N'C', N'Đơn vị đo tốc độ đường truyền', N'bps(bit per second)', N'Bps(Byte per second)', N'mps(meter per second)', N'hertz (ccle per second)', N'A', N'TH123   ', N'663b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (211, N'MMTCB', N'C', N'Repeater dùng để', N'Lọc bớt dữ liệu trên mạng', N'Tăng tốc độ lưu thông trên mạng', N'Tăng thời gian trễ trên mạng', N'Mở rộng chiều dài đường truyền', N'D', N'TH123   ', N'673b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (212, N'MMTCB', N'C', N'Cáp đồng trục (coaxial)', N'Có 4 đôi dây', N'Không cần repeater', N'Truyền tín hiệu ánh sáng', N'Chống nhiễu tốt hơn UTP', N'D', N'TH123   ', N'683b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (213, N'MMTCB', N'C', N'Câp Data link ', N'Truyền dữ liệu cho các cấp khác trong mạng', N'Cung cấp dịch vụ cho chương trình ứng dụng', N'Nhận tín hiệu yếu,lọc,khuếch đại và phát lại trên mạng', N'Bảo đảm đường truyền dữ liệu tin cậy giữa 2 đầu đường truyền', N'D', N'TH123   ', N'693b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (214, N'MMTCB', N'C', N'Địa chỉ IP còn gọi là', N'Địa chĩ vật lý', N'Địa chỉ luận lý', N'Địa chỉ thập phân', N'Địa chỉ thập lục phân', N'B', N'TH123   ', N'6a3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (215, N'MMTCB', N'C', N'Cấp Presentation', N'Thiết lập, quản lý và kết thúc các ứng dụng', N'Hướng dẫn cách mô tả hình ảnh, âm thanh, tiếng nói', N'Cung cấp dịch vụ truyền dữ liệu từ nguồn đến đích', N'Hỗ trợ việc truyền thông trong các ứng dụng như web, mail...', N'C', N'TH123   ', N'6b3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (216, N'MMTCB', N'C', N'Tập các luật để định dạng và truyền dữ liệu gọi là', N'Qui luật (rule)', N'Nghi thức (protocol)', N'Tiêu chuẩn (standard)', N'Mô hình (model)', N'B', N'TH123   ', N'6c3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (217, N'MMTCB', N'C', N'Tại sao cần có tiêu chuẩn về mang', N'Định hướng phát triển phần cứng và phần mềm mới', N'LAN,MAN và WAN sử dụng các thiết bị khác nhau', N'Kết nối mạng giữa các quôc gia khác nhau', N'Tương thích về công nghệ để truyền thông được lẫn nhau', N'D', N'TH123   ', N'6d3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (218, N'MMTCB', N'C', N'Dữ liệu truyền trên mạng bằng', N'Mã ASCII', N'Số nhị phân', N'Không và một', N'Xung điện áp', N'D', N'TH123   ', N'6e3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (219, N'MMTCB', N'C', N'Mạng CSMA/CD', N'Kiểm tra để bảo đảm dữ liệu truyền đến đích', N'Kiểm tra đường truyền nếu rảnh mới truyền dữ liệu', N'Chờ 1 thời gian ngẫu nhiên rồi truyền  dữ liệu kế tiếp', N'Tất cả đều đúng', N'B', N'TH123   ', N'6f3b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (220, N'MMTCB', N'C', N'Địa chỉ MAC ', N'Gồm có 32 bit', N'Còn gọi là địa chỉ logic', N'Nằm trong cấp Network', N'Dùng để phân biệt các máy trong mạng', N'D', N'TH123   ', N'703b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (223, N'MMTCB', N'B', N'isuydsuy', N'ksdyfus', N'sjflds', N'sdjfls', N'sidfuos', N'B', N'TH123   ', N'713b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (224, N'LTW  ', N'A', N'kjck', N'kjdks', N'kdjfhsk', N'jdhf', N'kxjdfk', N'C', N'TH123   ', N'723b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (225, N'AVCB ', N'A', N'Cháu lên ba cháu vô mẫu giáo, cô khen cháu cháu không khóc nhè.', N'1', N'2', N'3', N'4', N'C', N'TH123   ', N'733b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (228, N'LTW  ', N'B', N'asd', N'ad', N'dd', N'ds', N'cv', N'A', N'1       ', N'743b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[BODE] ([CAUHOI], [MAMH], [TRINHDO], [NOIDUNG], [A], [B], [C], [D], [DAP_AN], [MAGV], [rowguid]) VALUES (229, N'LTW  ', N'B', N'asdasd', N'asd', N'asd', N'asd', N'asd', N'B', N'TH234   ', N'753b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[COSO] ([MACS], [TENCS], [DIACHI], [rowguid]) VALUES (N'CS1', N'CO SO 1 ', N'11 Nguyễn Đình Chiểu Phường Đakao Q1', N'7d3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[COSO] ([MACS], [TENCS], [DIACHI], [rowguid]) VALUES (N'CS2', N'CO SO 2', N'Số 9 Man Thiện , quận 9', N'7e3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[GIAOVIEN] ([MAGV], [HO], [TEN], [DIACHI], [MAKH], [rowguid]) VALUES (N'1       ', N'Le thi ', N'A', N'Binh Phuoc', N'QTKD    ', N'8e3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[GIAOVIEN] ([MAGV], [HO], [TEN], [DIACHI], [MAKH], [rowguid]) VALUES (N'2       ', N'Dinh Van ', N'C', N'Ho Chi Minh', N'QTKD    ', N'8f3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[GIAOVIEN] ([MAGV], [HO], [TEN], [DIACHI], [MAKH], [rowguid]) VALUES (N'3       ', N'Le Thi ', N'Lanh', N'ho chi minh', N'QTKD    ', N'903a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[GIAOVIEN] ([MAGV], [HO], [TEN], [DIACHI], [MAKH], [rowguid]) VALUES (N'asd     ', N'asd', N'asd', N'asd', N'vt      ', N'09cce10f-89f0-eb11-8a77-34cff68b29d6')
INSERT [dbo].[GIAOVIEN] ([MAGV], [HO], [TEN], [DIACHI], [MAKH], [rowguid]) VALUES (N'TH101   ', N'KIEU DAC', N'THIEN', N'9,3A, Q.BINH TAN', N'CNTT    ', N'913a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[GIAOVIEN] ([MAGV], [HO], [TEN], [DIACHI], [MAKH], [rowguid]) VALUES (N'TH123   ', N'PHAN VAN ', N'HAI', N'15/72 LE VAN THO F8 GO VAP', N'CNTT    ', N'923a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[GIAOVIEN] ([MAGV], [HO], [TEN], [DIACHI], [MAKH], [rowguid]) VALUES (N'TH234   ', N'DAO VAN ', N'TUYET', N'14/7 BUI DINH TUY TAN BINH', N'CNTT    ', N'933a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[GIAOVIEN] ([MAGV], [HO], [TEN], [DIACHI], [MAKH], [rowguid]) VALUES (N'TH567   ', N'Dinh Van', N' Si', N'vung tau', N'CNTT    ', N'943a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[GIAOVIEN] ([MAGV], [HO], [TEN], [DIACHI], [MAKH], [rowguid]) VALUES (N'TH657   ', N'PHAN HONG', N'NGOC', N'TTTTT', N'VT      ', N'953a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[GIAOVIEN_DANGKY] ([MAGV], [MAMH], [MALOP], [TRINHDO], [NGAYTHI], [LAN], [SOCAUTHI], [THOIGIAN], [rowguid]) VALUES (N'TH234   ', N'AVCB ', N'TH04    ', N'B', CAST(N'2021-07-21 00:00:00.000' AS DateTime), 1, 10, 15, N'773b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[GIAOVIEN_DANGKY] ([MAGV], [MAMH], [MALOP], [TRINHDO], [NGAYTHI], [LAN], [SOCAUTHI], [THOIGIAN], [rowguid]) VALUES (N'TH123   ', N'AVCB ', N'VT04    ', N'B', CAST(N'2021-07-22 00:00:00.000' AS DateTime), 1, 10, 15, N'783b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[GIAOVIEN_DANGKY] ([MAGV], [MAMH], [MALOP], [TRINHDO], [NGAYTHI], [LAN], [SOCAUTHI], [THOIGIAN], [rowguid]) VALUES (N'TH123   ', N'MMTCB', N'VT04    ', N'A', CAST(N'2021-07-22 00:00:00.000' AS DateTime), 1, 10, 15, N'793b55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[KHOA] ([MAKH], [TENKH], [MACS], [rowguid]) VALUES (N'CNTT    ', N'Công nghệ thông tin 2', N'CS1', N'8a3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[KHOA] ([MAKH], [TENKH], [MACS], [rowguid]) VALUES (N'QTKD    ', N'Quản trị kinh doanh', N'CS1', N'8b3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[KHOA] ([MAKH], [TENKH], [MACS], [rowguid]) VALUES (N'VT      ', N'Viễn thông', N'CS2', N'8c3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[KHOA] ([MAKH], [TENKH], [MACS], [rowguid]) VALUES (N'VT1     ', N'VIỄN THÔNG 1', N'CS2', N'8d3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'qt      ', N'ád', N'QTKD    ', N'5ac45233-42f1-eb11-8a78-34cff68b29d6')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'QT1     ', N'QUAN TRI', N'QTKD    ', N'6eb3fc6d-d7ea-eb11-8a75-34cff68b29d6')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'TH04    ', N'TIN HOC 2004', N'CNTT    ', N'6fb3fc6d-d7ea-eb11-8a75-34cff68b29d6')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'TH05    ', N'TIN HOC 2005', N'CNTT    ', N'70b3fc6d-d7ea-eb11-8a75-34cff68b29d6')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'TH06    ', N'TIN HOC 2006', N'CNTT    ', N'71b3fc6d-d7ea-eb11-8a75-34cff68b29d6')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'TH07    ', N'TIN HOC 2007', N'CNTT    ', N'72b3fc6d-d7ea-eb11-8a75-34cff68b29d6')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'VT04    ', N'DET MAY 2004', N'VT      ', N'6cb3fc6d-d7ea-eb11-8a75-34cff68b29d6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'AVCB ', N'ANH VAN CAN BAN', N'7f3a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'CSDL ', N'CO SO DU LIEU', N'803a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'CTDL ', N'CAU TRUC DU LIEU', N'813a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'HQT  ', N'HE QUAN TRI CSDL', N'823a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'KTTSL', N'KY THUAT TRUYEN SO LIEU', N'833a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'LTMCB', N'LAP TRINH MANG CO BAN', N'843a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'LTW  ', N'LAP TRINH TREN WINDOW', N'853a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'MMTCB', N'MANG MAY TINH CAN BAN', N'863a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'toan ', N'taon cap 3', N'873a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'tv   ', N'tieng viet', N'883a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'vc   ', N'asdasd', N'742ef1f4-d6f1-eb11-8a78-34cff68b29d6')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'vl   ', N'vat ly', N'893a55a9-67eb-eb11-8a76-34cff68b29d6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'001     ', N'LE VAN ', N'THANH', CAST(N'1985-03-06 00:00:00.000' AS DateTime), N'23/5 PHUNG KHAC KHOAN F3 Q3', N'TH04    ', N'73b3fc6d-d7ea-eb11-8a75-34cff68b29d6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'002     ', N'DAO TRONG', N'KHAI', CAST(N'1979-08-19 00:00:00.000' AS DateTime), N'15/72 LE VAN THO F8 GOVAP', N'TH04    ', N'74b3fc6d-d7ea-eb11-8a75-34cff68b29d6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'003     ', N'CAO TUAN', N'KHA', CAST(N'1985-12-06 00:00:00.000' AS DateTime), N'12/5 LE QUANG DINH F5 GO VAP', N'TH04    ', N'75b3fc6d-d7ea-eb11-8a75-34cff68b29d6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'004     ', N'HA THANH ', N'BINH', CAST(N'1984-03-24 00:00:00.000' AS DateTime), N'23/4 HOANG HOA THAM', N'TH04    ', N'76b3fc6d-d7ea-eb11-8a75-34cff68b29d6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'005     ', N'NGUYEN THUY ', N'VAN', CAST(N'1987-11-06 00:00:00.000' AS DateTime), N'7 HUYNH THUC KHANG', N'TH05    ', N'77b3fc6d-d7ea-eb11-8a75-34cff68b29d6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'006     ', N'NGUYEN NGOC ', N'YEN', CAST(N'1980-11-23 00:00:00.000' AS DateTime), N'3/5 AN DUONG VUONG', N'TH05    ', N'78b3fc6d-d7ea-eb11-8a75-34cff68b29d6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'007     ', N'NGUYEN THUY ', N'DUNG', CAST(N'1988-05-23 00:00:00.000' AS DateTime), N'8 HUYNH VAN BANH f1 q binh thanh', N'TH05    ', N'79b3fc6d-d7ea-eb11-8a75-34cff68b29d6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'008     ', N'TRINH', N'PHONG', CAST(N'1985-12-10 00:00:00.000' AS DateTime), N'GGG', N'TH06    ', N'7ab3fc6d-d7ea-eb11-8a75-34cff68b29d6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'009     ', N'TRAN THANH', N'HUNG', CAST(N'1985-03-28 00:00:00.000' AS DateTime), N'jhjhj', N'TH05    ', N'7bb3fc6d-d7ea-eb11-8a75-34cff68b29d6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'010     ', N'SDFSD', N'SDFSDF', CAST(N'1985-03-26 00:00:00.000' AS DateTime), N'dfsd', N'TH05    ', N'7cb3fc6d-d7ea-eb11-8a75-34cff68b29d6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'011     ', N'PHAN HONG', N'NGOC', CAST(N'1986-01-17 00:00:00.000' AS DateTime), N'PHAN VAN HAN BINH THANH', N'TH05    ', N'7db3fc6d-d7ea-eb11-8a75-34cff68b29d6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'1       ', N's', N'da', CAST(N'2021-07-21 00:00:00.000' AS DateTime), N'asd', N'TH07    ', N'98106c3c-e0ea-eb11-8a75-34cff68b29d6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'2       ', N'Nguyen Van ', N'B', CAST(N'2021-07-06 00:00:00.000' AS DateTime), N'Binh Phuoc', N'QT1     ', N'7eb3fc6d-d7ea-eb11-8a75-34cff68b29d6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'3       ', N'Nguyen Van', N'C', CAST(N'2021-07-20 00:00:00.000' AS DateTime), N'Vung Tau', N'QT1     ', N'7fb3fc6d-d7ea-eb11-8a75-34cff68b29d6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'5       ', N'ad', N'as', CAST(N'2021-07-21 00:00:00.000' AS DateTime), N'asd', N'QT1     ', N'7462e833-e0ea-eb11-8a75-34cff68b29d6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'n17d2   ', N'Le Van ', N'DF', CAST(N'2021-07-07 00:00:00.000' AS DateTime), N'ca mau', N'TH07    ', N'42ef66cf-e0ea-eb11-8a75-34cff68b29d6')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [NGAYSINH], [DIACHI], [MALOP], [rowguid]) VALUES (N'VT1     ', N'LE VAN ', N'SI', CAST(N'1998-07-13 00:00:00.000' AS DateTime), N'CA MAU', N'VT04    ', N'07cc7303-6aeb-eb11-8a76-34cff68b29d6')
/****** Object:  Index [UQ__BANGDIEM__603FFF88E07C4574]    Script Date: 7/31/2021 7:42:50 PM ******/
ALTER TABLE [dbo].[BANGDIEM] ADD UNIQUE NONCLUSTERED 
(
	[MABD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UN_TENLOP]    Script Date: 7/31/2021 7:42:50 PM ******/
ALTER TABLE [dbo].[LOP] ADD  CONSTRAINT [UN_TENLOP] UNIQUE NONCLUSTERED 
(
	[TENLOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UN_TENMH]    Script Date: 7/31/2021 7:42:50 PM ******/
ALTER TABLE [dbo].[MONHOC] ADD  CONSTRAINT [UN_TENMH] UNIQUE NONCLUSTERED 
(
	[TENMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BAITHI]  WITH CHECK ADD  CONSTRAINT [FK_BAITHI_BANGDIEM] FOREIGN KEY([MABD])
REFERENCES [dbo].[BANGDIEM] ([MABD])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[BAITHI] CHECK CONSTRAINT [FK_BAITHI_BANGDIEM]
GO
ALTER TABLE [dbo].[BANGDIEM]  WITH CHECK ADD  CONSTRAINT [FK_BANGDIEM_MONHOC] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
GO
ALTER TABLE [dbo].[BANGDIEM] CHECK CONSTRAINT [FK_BANGDIEM_MONHOC]
GO
ALTER TABLE [dbo].[BANGDIEM]  WITH NOCHECK ADD  CONSTRAINT [FK_BANGDIEM_SINHVIEN1] FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[BANGDIEM] CHECK CONSTRAINT [FK_BANGDIEM_SINHVIEN1]
GO
ALTER TABLE [dbo].[BODE]  WITH CHECK ADD  CONSTRAINT [FK_BODE_GIAOVIEN] FOREIGN KEY([MAGV])
REFERENCES [dbo].[GIAOVIEN] ([MAGV])
GO
ALTER TABLE [dbo].[BODE] CHECK CONSTRAINT [FK_BODE_GIAOVIEN]
GO
ALTER TABLE [dbo].[BODE]  WITH CHECK ADD  CONSTRAINT [FK_BODE_MONHOC] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
GO
ALTER TABLE [dbo].[BODE] CHECK CONSTRAINT [FK_BODE_MONHOC]
GO
ALTER TABLE [dbo].[GIAOVIEN]  WITH CHECK ADD  CONSTRAINT [FK_GIAOVIEN_KHOA] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHOA] ([MAKH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GIAOVIEN] CHECK CONSTRAINT [FK_GIAOVIEN_KHOA]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY]  WITH CHECK ADD  CONSTRAINT [FK_GIAOVIEN_DANGKY_GIAOVIEN1] FOREIGN KEY([MAGV])
REFERENCES [dbo].[GIAOVIEN] ([MAGV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] CHECK CONSTRAINT [FK_GIAOVIEN_DANGKY_GIAOVIEN1]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY]  WITH CHECK ADD  CONSTRAINT [FK_GIAOVIEN_DANGKY_LOP_] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] CHECK CONSTRAINT [FK_GIAOVIEN_DANGKY_LOP_]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY]  WITH CHECK ADD  CONSTRAINT [FK_GIAOVIEN_DANGKY_MONHOC1] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] CHECK CONSTRAINT [FK_GIAOVIEN_DANGKY_MONHOC1]
GO
ALTER TABLE [dbo].[KHOA]  WITH CHECK ADD  CONSTRAINT [FK_KHOA_COSO] FOREIGN KEY([MACS])
REFERENCES [dbo].[COSO] ([MACS])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[KHOA] CHECK CONSTRAINT [FK_KHOA_COSO]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [FK_LOP_KHOA] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHOA] ([MAKH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [FK_LOP_KHOA]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_LOP] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_LOP]
GO
ALTER TABLE [dbo].[BAITHI]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_D2698181_4134_4AA8_9951_23FA3476B75F] CHECK NOT FOR REPLICATION (([STT]>(70020) AND [STT]<=(71020) OR [STT]>(71020) AND [STT]<=(72020)))
GO
ALTER TABLE [dbo].[BAITHI] CHECK CONSTRAINT [repl_identity_range_D2698181_4134_4AA8_9951_23FA3476B75F]
GO
ALTER TABLE [dbo].[BANGDIEM]  WITH NOCHECK ADD  CONSTRAINT [CK_DIEM] CHECK  (([DIEM]>=(0) AND [DIEM]<=(10)))
GO
ALTER TABLE [dbo].[BANGDIEM] CHECK CONSTRAINT [CK_DIEM]
GO
ALTER TABLE [dbo].[BANGDIEM]  WITH NOCHECK ADD  CONSTRAINT [CK_LANTHI] CHECK  (([LAN]>=(1) AND [LAN]<=(2)))
GO
ALTER TABLE [dbo].[BANGDIEM] CHECK CONSTRAINT [CK_LANTHI]
GO
ALTER TABLE [dbo].[BANGDIEM]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_4841952A_E70A_4717_9C38_C3528D6EE139] CHECK NOT FOR REPLICATION (([MABD]>(70004) AND [MABD]<=(71004) OR [MABD]>(71004) AND [MABD]<=(72004)))
GO
ALTER TABLE [dbo].[BANGDIEM] CHECK CONSTRAINT [repl_identity_range_4841952A_E70A_4717_9C38_C3528D6EE139]
GO
ALTER TABLE [dbo].[BODE]  WITH NOCHECK ADD  CONSTRAINT [CK_BODE] CHECK  (([TRINHDO]='A' OR [TRINHDO]='B' OR [TRINHDO]='C'))
GO
ALTER TABLE [dbo].[BODE] CHECK CONSTRAINT [CK_BODE]
GO
ALTER TABLE [dbo].[BODE]  WITH NOCHECK ADD  CONSTRAINT [CK_DAPAN] CHECK  (([DAP_AN]='D' OR ([DAP_AN]='C' OR ([DAP_AN]='B' OR [DAP_AN]='A'))))
GO
ALTER TABLE [dbo].[BODE] CHECK CONSTRAINT [CK_DAPAN]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY]  WITH CHECK ADD  CONSTRAINT [CK_LAN] CHECK  (([LAN]>=(1) AND [LAN]<=(2)))
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] CHECK CONSTRAINT [CK_LAN]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY]  WITH CHECK ADD  CONSTRAINT [CK_SOCAUTHI] CHECK  (([SOCAUTHI]>=(10) AND [SOCAUTHI]<=(100)))
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] CHECK CONSTRAINT [CK_SOCAUTHI]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY]  WITH CHECK ADD  CONSTRAINT [CK_THOIGIAN] CHECK  (([THOIGIAN]>=(15) AND [THOIGIAN]<=(60)))
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] CHECK CONSTRAINT [CK_THOIGIAN]
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY]  WITH CHECK ADD  CONSTRAINT [CK_TRINHDO] CHECK  (([TRINHDO]='C' OR ([TRINHDO]='B' OR [TRINHDO]='A')))
GO
ALTER TABLE [dbo].[GIAOVIEN_DANGKY] CHECK CONSTRAINT [CK_TRINHDO]
GO
/****** Object:  StoredProcedure [dbo].[SP_DS_DANG_KY_THI]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DS_DANG_KY_THI] 
@MACS CHAR(3), 
@FROM DATE, 
@TO DATE
AS
BEGIN

CREATE TABLE #tbl_temp(
					MALOP CHAR(8)
					,TENLOP VARCHAR(40)
					,MAMH CHAR(8)
					,LAN SMALLINT
				)
CREATE TABLE #tbl_temp2(
					MALOP CHAR(8)
					,TENLOP VARCHAR(40)
					,MAGV CHAR(8)
					,MAMH CHAR(8)
					,LAN SMALLINT
				    ,NGAYTHI DATE
					,SOCAUTHI SMALLINT
					,DATHI BIT
					)			

--Lấy danh sách các lượt đăng ký thi theo cơ sở		
INSERT INTO #tbl_temp(MALOP, TENLOP, MAMH, LAN)
SELECT ll.MALOP, ll.TENLOP, gvdk.MAMH, gvdk.LAN
FROM
	(SELECT l.MALOP, l.TENLOP, l.MAKH 
	FROM
		LINK0.TN_CSDLPT.dbo.KHOA k, LINK0.TN_CSDLPT.dbo.LOP l
	WHERE (k.MACS = @MACS AND l.MAKH = k.MAKH)
	) AS ll, LINK0.TN_CSDLPT.dbo.GIAOVIEN_DANGKY gvdk
WHERE ((gvdk.NGAYTHI Between @FROM AND @TO) AND ll.MALOP = gvdk.MALOP) 

--Đếm số lượt đã thi thông qua table bảng điểm
SELECT lsv.TENLOP, lsv.MALOP, lsv.MAMH, lsv.LAN, COUNT(bd.MASV) AS 'DATHI' 
INTO #tbl_temp3
FROM
(
	SELECT t.TENLOP, t.MALOP, t.MAMH, t.LAN, sv.MASV 
	FROM 
	(
		#tbl_temp t left join LINK0.TN_CSDLPT.dbo.SINHVIEN sv
		ON t.MALOP = sv.MALOP
	)
)AS lsv
left join
LINK0.TN_CSDLPT.dbo.BANGDIEM bd
ON bd.MASV = lsv.MASV And bd.MAMH = lsv.MAMH And bd.LAN = lsv.LAN
GROUP BY lsv.MALOP, lsv.TENLOP, lsv.MAMH, lsv.LAN

--Lấy thêm thông tin cho báo cáo
SELECT t.TENLOP, t.MAMH, gvdk.MAGV, gvdk.SOCAUTHI, t.LAN, gvdk.NGAYTHI, t.DATHI
INTO #tbl_Info
FROM 
#tbl_temp3 t
inner join 
LINK0.TN_CSDLPT.dbo.GIAOVIEN_DANGKY gvdk
ON (t.MALOP = gvdk.MALOP And t.MAMH = gvdk.MAMH And t.LAN = gvdk.LAN)

--Sửa các mã thành tên
SELECT t.TENLOP, rs1.TENMH, ftt.HOTEN, t.SOCAUTHI,t.LAN, t.NGAYTHI, t.DATHI
FROM 
(
#tbl_Info t
inner join 
(SELECT mh.MAMH, mh.TENMH FROM LINK0.TN_CSDLPT.dbo.MONHOC mh 
 WHERE mh.MAMH in (SELECT ti.MAMH FROM #tbl_Info ti)) AS rs1
ON t.MAMH = rs1.MAMH
)
inner join 
(SELECT gv.MAGV, (gv.HO + gv.TEN) AS 'HOTEN' FROM LINK0.TN_CSDLPT.dbo.GIAOVIEN gv 
 WHERE gv.MAGV in (SELECT ti.MAGV FROM #tbl_Info ti)) AS ftt
ON t.MAGV = ftt.MAGV

DROP TABLE #tbl_temp
DROP TABLE #tbl_temp2
DROP TABLE #tbl_temp3
DROP TABLE #tbl_Info

END
GO
/****** Object:  StoredProcedure [dbo].[SP_IN_BAI_THI]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_IN_BAI_THI]
@maSV nchar(8),
@maMH nchar(5),
@lan smallint

AS 
 BEGIN
	DECLARE @maBD int;

	SELECT @maBD =  BANGDIEM.MABD FROM BANGDIEM WHERE BANGDIEM.MASV = @maSV AND BANGDIEM.MAMH = @maMH AND BANGDIEM.LAN = @lan;
	SELECT BAITHI.CAUHOI, BAITHI.NoiDung, CONCAT(N'A. ' , CONVERT(NVARCHAR(MAX),BAITHI.A)) AS A ,CONCAT( N'B. ' , CONVERT(NVARCHAR(MAX),BAITHI.B)) AS B ,CONCAT( N'C. ' , CONVERT(NVARCHAR(MAX),BAITHI.C) ) AS C ,CONCAT(N'D. ' , CONVERT(NVARCHAR(MAX),BAITHI.D))  AS D , BAITHI.DAPAN, BAITHI.SVTRON FROM BAITHI WHERE BAITHI.MaBD = @maBD
 END;

GO
/****** Object:  StoredProcedure [dbo].[SP_IN_DS_BANG_DIEM]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_IN_DS_BANG_DIEM] 
@MALOP CHAR(8), 
@MAMH CHAR(8), 
@LAN INT
AS
BEGIN
	SELECT lsv.MASV, [HO VA TEN], DIEM
	FROM
		(SELECT sv.MASV, (sv.HO + sv.TEN) AS 'HO VA TEN'  
		 FROM SINHVIEN sv
		 WHERE (sv.MALOP = @MALOP)) As lsv
	   Inner Join
		(SELECT bd.MASV, bd.DIEM 
		 FROM  BANGDIEM bd
		 WHERE (bd.MAMH = @MAMH AND bd.LAN = @LAN )) AS bdl 
	   ON lsv.MASV = bdl.MASV
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_BAI_THI]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_INSERT_BAI_THI]

	@CAUHOI INT,
	@NOIDUNG NTEXT,
	@A NTEXT,
	@B NTEXT,
	@C NTEXT,
	@D NTEXT,
	@DAPAN CHAR(1),
	@SVTRON CHAR(1),
	@MABD int
AS
BEGIN	
	INSERT INTO BAITHI(CAUHOI, NOIDUNG, A,B,C,D, DAPAN, SVTRON, MABD)
	VALUES (@CAUHOI, @NOIDUNG, @A, @B, @C, @D,@DAPAN,@SVTRON,@MABD)	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_BAI_THI_NEW]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_INSERT_BAI_THI_NEW]

	@CAUHOI INT,
	@NOIDUNG NTEXT,
	@A NTEXT,
	@B NTEXT,
	@C NTEXT,
	@D NTEXT,
	@DAPAN CHAR(1),
	@SVTRON CHAR(1),
	@MABD int
AS
BEGIN	
	INSERT INTO BAITHI(CAUHOI, NOIDUNG, A,B,C,D, DAPAN, SVTRON, MABD)
	VALUES (@CAUHOI, @NOIDUNG, @A, @B, @C, @D,@DAPAN,@SVTRON,@MABD)	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_BANG_DIEM]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_INSERT_BANG_DIEM]

	@MASV CHAR(8),
	@MAMH CHAR(5),
	@LANTHI INT,
	@NGAYTHI DATETIME,
	@DIEM FLOAT

AS
BEGIN
	INSERT INTO BANGDIEM(MASV, MAMH, LAN,NGAYTHI, DIEM)
	VALUES (@MASV, @MAMH, @LANTHI,@NGAYTHI, @DIEM)	

END
GO
/****** Object:  StoredProcedure [dbo].[SP_KIEM_MA_KHOA]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_KIEM_MA_KHOA] 
@MAKH CHAR(8)
AS
BEGIN 

	 -- KIEM TRA TRONG TABLE SINH VIEN CUA SERVER HIEN TAI
	 IF EXISTS(SELECT MAKH FROM KHOA WHERE MAKH = @MAKH)
		BEGIN
			SELECT  '1' ; -- MA SV TON TAI 
		END
	 -- KIEM TRA TRONG TABLE SINH VIEN CUA PHAN MANH CON LAI
	 ELSE IF EXISTS(SELECT MAKH FROM LINK1.TN_CSDLPT.DBO.KHOA KHOA WHERE KHOA.MAKH = @MAKH)
		BEGIN
			SELECT  '1' ; -- MA SV TON TAI
		END
	ELSE
		BEGIN
			SELECT  '0' ;
		END	
END

GO
/****** Object:  StoredProcedure [dbo].[SP_KIEM_MA_LOP]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_KIEM_MA_LOP] 
@MALOP CHAR(8)
AS
BEGIN 

	 -- KIEM TRA TRONG TABLE SINH VIEN CUA SERVER HIEN TAI
	 IF EXISTS(SELECT MALOP FROM LOP WHERE MALOP = @MALOP)
		BEGIN
			SELECT  '1' ; -- MA SV TON TAI 
		END
	 -- KIEM TRA TRONG TABLE SINH VIEN CUA PHAN MANH CON LAI
	 ELSE IF EXISTS(SELECT MALOP FROM LINK1.TN_CSDLPT.DBO.LOP LOP WHERE LOP.MALOP = @MALOP)
		BEGIN
			SELECT  '1' ; -- MA SV TON TAI
		END
	ELSE
		BEGIN
			SELECT  '0' ;
		END	
END

GO
/****** Object:  StoredProcedure [dbo].[SP_KIEM_TRA_MA_SV]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_KIEM_TRA_MA_SV]
@MASV CHAR(8)
AS
BEGIN 

	 -- KIEM TRA TRONG TABLE SINH VIEN CUA SERVER HIEN TAI
	 IF EXISTS(SELECT MASV FROM SINHVIEN WHERE MASV = @MASV)
		BEGIN
			SELECT  '1' ; -- MA SV TON TAI 
		END
	 -- KIEM TRA TRONG TABLE SINH VIEN CUA PHAN MANH CON LAI
	 ELSE IF EXISTS(SELECT MASV FROM LINK1.TN_CSDLPT.DBO.SINHVIEN SINHVIEN WHERE SINHVIEN.MASV = @MASV)
		BEGIN
			SELECT  '1' ; -- MA SV TON TAI
		END
	ELSE
		BEGIN
			SELECT  '0' ;
		END	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_KIEM_TRA_SV]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_KIEM_TRA_SV] @MASV CHAR(8), 
@MAMH CHAR(5), 
@LAN INT
AS

BEGIN
	IF EXISTS (SELECT * FROM BANGDIEM WHERE MASV=@MASV AND MAMH=@MAMH AND LAN=@LAN )
		
		SELECT '1';

	ELSE 

		SELECT '0';

END
GO
/****** Object:  StoredProcedure [dbo].[SP_KT_MON_HOC_TON_TAI]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_KT_MON_HOC_TON_TAI]
	 @MAMH nchar(5)
AS
BEGIN
	 IF EXISTS(SELECT MAMH FROM  dbo.MONHOC WHERE MAMH = @MAMH)
		BEGIN
			RETURN  1 ; 
		END
	 ELSE
		BEGIN
			RETURN  0 ;
		END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_lAY_CAU_HOI]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_lAY_CAU_HOI]
@maMonHoc NCHAR(5), @trinhDo NChar(1), @soCau int
AS
BEGIN
	DECLARE @trinhDo2 Nchar(1) = 'N'
	DECLARE @countQuestion int = 0
	DECLARE @countQuestionCungTrinhDo int = 0
	DECLARE @countQuestionTrinhDoDuoi int = 0

	set @countQuestionCungTrinhDo = (select count(*) from BODE where (MAMH = @maMonHoc and TRINHDO = @trinhDo))

	if (@trinhDo = 'A') 
		set @trinhDo2 = 'B'
	else if (@trinhDo = 'B')
		set @trinhDo2 = 'C' 
	
		set @countQuestionTrinhDoDuoi = (select count(*) from BODE where (MAMH = @maMonHoc and TRINHDO = @trinhDo2))
		set @countQuestion = @countQuestionCungTrinhDo+@countQuestionTrinhDoDuoi
		
		--set @countQuestion = @countQuestionCungTrinhDo

	if(@countQuestion <@soCau or @countQuestionCungTrinhDo<(@soCau*70/100))
		begin
			Select('Khong du cau hoi de thi') as 'ERROR'
			return -1
		end
	
	-- tạo bảng tạm chưa các câu hỏi tại tất cả các site theo input ban đầu
	create table AtSiteTable(
	CAUHOI int primary key,
	TRINHDO char(1),
	NOIDUNG ntext,
	A ntext,
	B ntext,
	C ntext,
	D ntext,
	DAP_AN nchar(1),
	)

	select * into CungTrinhDoAtSiteTable from BODE  where MAMH = @maMonHoc and TRINHDO = @trinhDo and MAGV in (Select MAGV from GIAOVIEN where MAKH in(select MAKH from KHOA))
	select * into TrinhDoDuoiAtSiteTable from BODE  where MAMH = @maMonHoc and TRINHDO = @trinhDo2 and MAGV in (Select MAGV from GIAOVIEN where MAKH in(select MAKH from KHOA))
	
	Insert into AtSiteTable
			select CAUHOI,TRINHDO,CAST(NOIDUNG as nvarchar(max)),CAST(A as nvarchar(max)),CAST(B as nvarchar(max)),CAST(C as nvarchar(max)),
			CAST(D as nvarchar(max)),DAP_AN from CungTrinhDoAtSiteTable
			UNION
			select CAUHOI,TRINHDO,CAST(NOIDUNG as nvarchar(max)),CAST(A as nvarchar(max)),CAST(B as nvarchar(max)),CAST(C as nvarchar(max)),
			CAST(D as nvarchar(max)),DAP_AN  from TrinhDoDuoiAtSiteTable 
	
	Declare @countCungTrinhDoAtSite int = (select count(*) from CungTrinhDoAtSiteTable)
	Declare @countTrinhDoDuoiAtSite int = (select count(*) from TrinhDoDuoiAtSiteTable)
	if((@countCungTrinhDoAtSite+@countTrinhDoDuoiAtSite) < @soCau OR @countCungTrinhDoAtSite < (@soCau*70/100))
		begin
			print 'here'
			select * into CungTrinhDoOtherSiteTable from BODE  where MAMH = @maMonHoc and TRINHDO = @trinhDo and MAGV in (Select MAGV from GIAOVIEN where MAKH not in(select MAKH from KHOA))
			select * into TrinhDoDuoiOtherSiteTable from BODE  where MAMH = @maMonHoc and TRINHDO = @trinhDo2 and MAGV in (Select MAGV from GIAOVIEN where MAKH not in(select MAKH from KHOA))

			Insert into AtSiteTable
			select CAUHOI,TRINHDO,CAST(NOIDUNG as nvarchar(max)),CAST(A as nvarchar(max)),CAST(B as nvarchar(max)),CAST(C as nvarchar(max)),
			CAST(D as nvarchar(max)),DAP_AN from CungTrinhDoOtherSiteTable
			UNION
			select CAUHOI,TRINHDO,CAST(NOIDUNG as nvarchar(max)),CAST(A as nvarchar(max)),CAST(B as nvarchar(max)),CAST(C as nvarchar(max)),
			CAST(D as nvarchar(max)),DAP_AN  from TrinhDoDuoiOtherSiteTable 
			drop table CungTrinhDoOtherSiteTable
			drop table TrinhDoDuoiOtherSiteTable
		end
	Declare @slCanLayCungTrinhDo int,@slCanLayTrinhDoDuoi int
		set @slCanLayCungTrinhDo = @soCau*70/100
		if ((@slCanLayCungTrinhDo + @countQuestionTrinhDoDuoi)<@soCau)
			set @slCanLayCungTrinhDo = @slCanLayCungTrinhDo + (@soCau - (@slCanLayCungTrinhDo+@countQuestionTrinhDoDuoi))
			set @slCanLayTrinhDoDuoi = @soCau - @slCanLayCungTrinhDo
		
	select top (@slCanLayCungTrinhDo) * into temp1 from AtSiteTable where TRINHDO = @trinhDo
	ORDER BY NEWID()
	
	select top (@slCanLayTrinhDoDuoi) * into temp2 from AtSiteTable where TRINHDO = @trinhDo2
	ORDER BY NEWID()

	select CAUHOI,CAST(NOIDUNG as nvarchar(max)) as [NOIDUNG],CAST(A as nvarchar(max)) as [A],CAST(B as nvarchar(max)) as [B],CAST(C as nvarchar(max)) as [C],
	CAST(D as nvarchar(max)) as [D],DAP_AN  from temp1
	UNION
	select CAUHOI,CAST(NOIDUNG as nvarchar(max)) as [NOIDUNG],CAST(A as nvarchar(max)) as [A],CAST(B as nvarchar(max)) as [B],CAST(C as nvarchar(max)) as [C],
	CAST(D as nvarchar(max)) as [D],DAP_AN  from temp2

	drop table AtSiteTable
	drop table CungTrinhDoAtSiteTable
	drop table TrinhDoDuoiAtSiteTable
	drop table temp1
	drop table temp2
	--
	
END

GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_MA_BANG_DIEM]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LAY_MA_BANG_DIEM]

	@MASV CHAR(8),
	@MAMH CHAR(5),
	@LANTHI INT

AS
BEGIN
	SELECT MABD FROM BANGDIEM WHERE MASV=@MASV AND MAMH=@MAMH AND LAN=@LANTHI
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_THONG_TIN_DANG_NHAP]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LAY_THONG_TIN_DANG_NHAP]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50)
SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
 
 SELECT USERNAME = @TENUSER, 
  HOTEN = (SELECT HO+ ' '+ TEN FROM GIAOVIEN  WHERE MAGV = @TENUSER ),
   TENNHOM= NAME
   FROM sys.sysusers 
   WHERE UID = (SELECT GROUPUID 
                 FROM SYS.SYSMEMBERS 
                   WHERE MEMBERUID= (SELECT UID FROM sys.sysusers 
                                      WHERE NAME=@TENUSER))

GO
/****** Object:  StoredProcedure [dbo].[SP_LAY_THONG_TIN_DANG_NHAP_SINHVIEN]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LAY_THONG_TIN_DANG_NHAP_SINHVIEN]
@MASV char(8)
as
begin
	Select (sv.HO + sv.TEN) as 'FULL NAME', sv.MALOP
	INTO TTSV
	From SINHVIEN sv WHERE sv.MASV = @MASV

	Select TTSV.[FULL NAME], TTSV.MALOP, l.TENLOP
	FROM TTSV
	INNER JOIN dbo.LOP l on TTSV.MALOP = l.MALOP
	
	Drop Table TTSV
end
GO
/****** Object:  StoredProcedure [dbo].[SP_TAO_TAI_KHOAN]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_TAO_TAI_KHOAN]
	@LGNAME VARCHAR(50),
	@PASS VARCHAR(50),
	@USERNAME VARCHAR(50),
	@ROLE VARCHAR(50)
AS
BEGIN
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'TN_CSDLPT'                     

  IF (@RET =1)  -- LOGIN NAME BI TRUNG
     RETURN 1

  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
  END
  EXEC sp_addrolemember @ROLE, @USERNAME

  IF @ROLE= 'TRUONG' 
	BEGIN
		EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END

  IF @ROLE= 'COSO'
	BEGIN 
		EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END
  IF @ROLE= 'GIANGVIEN'
	BEGIN  
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END
  IF @ROLE= 'SINHVIEN'
	BEGIN  
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END

END
GO
/****** Object:  StoredProcedure [dbo].[SP_THONG_THI]    Script Date: 7/31/2021 7:42:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_THONG_THI]
@MAMH CHAR(8), 
@NGAYTHI DATETIME, 
@LAN INT
AS

BEGIN
	IF EXISTS (SELECT * FROM GIAOVIEN_DANGKY WHERE MAMH=@MAMH AND NGAYTHI=@NGAYTHI AND LAN=@LAN )
		SELECT TRINHDO, SOCAUTHI, THOIGIAN FROM GIAOVIEN_DANGKY
		WHERE MAMH=@MAMH AND NGAYTHI=@NGAYTHI AND LAN=@LAN

	ELSE 
		RAISERROR ('Không tìm thấy thông tin thi',16,1)
	
END
GO
