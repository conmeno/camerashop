USE [CameraShop]
GO
/****** Object:  Table [dbo].[ThongSo]    Script Date: 05/13/2013 23:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongSo](
	[MaThongSo] [int] IDENTITY(1,1) NOT NULL,
	[TenThongSo] [nvarchar](100) NOT NULL,
	[TinhTrang] [bit] NOT NULL,
 CONSTRAINT [PK_ThongSo] PRIMARY KEY CLUSTERED 
(
	[MaThongSo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ThongSo] ON
INSERT [dbo].[ThongSo] ([MaThongSo], [TenThongSo], [TinhTrang]) VALUES (1, N'Màu sắc', 1)
INSERT [dbo].[ThongSo] ([MaThongSo], [TenThongSo], [TinhTrang]) VALUES (2, N'Kích cỡ', 1)
INSERT [dbo].[ThongSo] ([MaThongSo], [TenThongSo], [TinhTrang]) VALUES (3, N'Chất liệu', 1)
INSERT [dbo].[ThongSo] ([MaThongSo], [TenThongSo], [TinhTrang]) VALUES (4, N'Kiểu dáng', 1)
SET IDENTITY_INSERT [dbo].[ThongSo] OFF
/****** Object:  Table [dbo].[Parameters]    Script Date: 05/13/2013 23:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Parameters](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LeftAd] [varchar](max) NULL,
	[RightAd] [varchar](max) NULL,
	[ContactContent] [varchar](max) NULL,
 CONSTRAINT [PK_Parameters] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Parameters] ON
INSERT [dbo].[Parameters] ([ID], [LeftAd], [RightAd], [ContactContent]) VALUES (1, N'<div id="BasicLogo49" style="width:180px; height:300px;">
	<a href="http://180.148.142.153/clk.aspx?lg=-1&amp;t=5&amp;i=0&amp;b=8737&amp;s=1&amp;r=0&amp;c=83&amp;p=49&amp;n=0&amp;l=http%3A//vietcombank.com.vn/News/Vcb_News.aspx%3FID%3D4913&amp;uc=32&amp;uv=undefined&amp;ud=1366x768&amp;rd=0.5515366406179965&amp;ui=36ad542671684be5-83-83" target="_blank"><img border="0" height="300" src="http://st.polyad.net/AdImages/2013/04/01/vcb_180x300_290313(8).jpg" width="180" /></a></div>
', N'<div class="content-right fl" style="margin-top:0px">
	<script type="text/javascript" language="JavaScript">Poly_ShowSpecialRight(); Poly_ShowAdScrollBanner(2);</script>
	<div id="BASIC_LOGO">
		<div id="adgroup" style="display:none;clear:both;">
			&nbsp;</div>
		<div class="fl" id="BasicLogo42_available" style="margin-bottom:0;">
			<div id="BasicLogo42" style="width:180px; height:300px;">
				<object border="0" classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" codebase="http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,0,0" height="300" width="180"><param name="movie" value="http://st.polyad.net/AdImages/2013/04/18/GoldPlace_180x300_170413(2).swf" /><param name="AllowScriptAccess" value="always" /><param name="quality" value="High" /><param name="wmode" value="transparent" /><param name="FlashVars" value="link=http%3A//180.148.142.153/clk.aspx%3Flg%3D-1%26t%3D5%26i%3D0%26b%3D51248%26s%3D1%26r%3D0%26c%3D1%26p%3D42%26n%3D0%26l%3Dhttp%253A//goldenpalace.vn/%26uc%3D32%26uv%3Dundefined%26ud%3D1366x768%26rd%3D0.13094274327158928%26ui%3D36ad542671684be5-1-1&amp;zoneid=BasicLogo42&amp;actionTag=http%3A//180.148.142.153/act.aspx%3Ft%3D5%26i%3D0%26b%3D51248%26s%3D1%26r%3D0%26c%3D1%26p%3D42%26n%3D0%26uc%3D32%26uv%3Dundefined%26ud%3D1366x768%26rd%3D0.9476073053665459" /><embed allowscriptaccess="always" flashvars="link=http%3A//180.148.142.153/clk.aspx%3Flg%3D-1%26t%3D5%26i%3D0%26b%3D51248%26s%3D1%26r%3D0%26c%3D1%26p%3D42%26n%3D0%26l%3Dhttp%253A//goldenpalace.vn/%26uc%3D32%26uv%3Dundefined%26ud%3D1366x768%26rd%3D0.13094274327158928%26ui%3D36ad542671684be5-1-1&amp;zoneid=BasicLogo42&amp;actionTag=http%3A//180.148.142.153/act.aspx%3Ft%3D5%26i%3D0%26b%3D51248%26s%3D1%26r%3D0%26c%3D1%26p%3D42%26n%3D0%26uc%3D32%26uv%3Dundefined%26ud%3D1366x768%26rd%3D0.9476073053665459" height="300" loop="true" play="true" pluginspage="http://www.macromedia.com/go/getflashplayer" src="http://st.polyad.net/AdImages/2013/04/18/GoldPlace_180x300_170413(2).swf" type="application/x-shockwave-flash" width="180" wmode="transparent"></embed></object></div>
		</div>
		<div class="adv-header">
			&nbsp;</div>
		<div class="fl" id="BasicLogo43_available" style="margin-bottom:0">
			<div id="BasicLogo43" style="width:180px; height:300px;">
				<object border="0" classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" codebase="http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,0,0" height="300" width="180"><param name="movie" value="http://st.polyad.net/AdImages/2013/05/10/acecook_180x300_1104.swf" /><param name="AllowScriptAccess" value="always" /><param name="quality" value="High" /><param name="wmode" value="transparent" /><param name="FlashVars" value="link=http%3A//180.148.142.153/clk.aspx%3Flg%3D-1%26t%3D5%26i%3D0%26b%3D56605%26s%3D1%26r%3D0%26c%3D1%26p%3D43%26n%3D0%26l%3Dhttp%253A//www.acecookvietnam.com/index.php%253Foption%253Dcom_content%2526task%253Dview%2526id%253D102%2526Itemid%253D101%2526lang%253Dvi%26uc%3D32%26uv%3Dundefined%26ud%3D1366x768%26rd%3D0.16956661851145327%26ui%3D36ad542671684be5-1-1&amp;zoneid=BasicLogo43&amp;actionTag=http%3A//180.148.142.153/act.aspx%3Ft%3D5%26i%3D0%26b%3D56605%26s%3D1%26r%3D0%26c%3D1%26p%3D43%26n%3D0%26uc%3D32%26uv%3Dundefined%26ud%3D1366x768%26rd%3D0.42833397327922285" /><embed allowscriptaccess="always" flashvars="link=http%3A//180.148.142.153/clk.aspx%3Flg%3D-1%26t%3D5%26i%3D0%26b%3D56605%26s%3D1%26r%3D0%26c%3D1%26p%3D43%26n%3D0%26l%3Dhttp%253A//www.acecookvietnam.com/index.php%253Foption%253Dcom_content%2526task%253Dview%2526id%253D102%2526Itemid%253D101%2526lang%253Dvi%26uc%3D32%26uv%3Dundefined%26ud%3D1366x768%26rd%3D0.16956661851145327%26ui%3D36ad542671684be5-1-1&amp;zoneid=BasicLogo43&amp;actionTag=http%3A//180.148.142.153/act.aspx%3Ft%3D5%26i%3D0%26b%3D56605%26s%3D1%26r%3D0%26c%3D1%26p%3D43%26n%3D0%26uc%3D32%26uv%3Dundefined%26ud%3D1366x768%26rd%3D0.42833397327922285" height="300" loop="true" play="true" pluginspage="http://www.macromedia.com/go/getflashplayer" src="http://st.polyad.net/AdImages/2013/05/10/acecook_180x300_1104.swf" type="application/x-shockwave-flash" width="180" wmode="transparent"></embed></object></div>
		</div>
		<div class="fl" id="BasicLogo44_available" style="margin-bottom:0;">
			<div id="BasicLogo44" style="position: absolute; overflow: hidden; z-index: 100; top: 1208px; left: 995px; width: 180px; height: 300px;">
				<div id="BasicLogo44_child" style="overflow: hidden; position: absolute; top: 0px; left: 0px; width: 180px; height: 300px;">
					<object border="0" classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" codebase="http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,0,0" height="300" width="180"><param name="movie" value="http://st.polyad.net/AdImages/2013/05/09/scaroflife_180x300.swf" /><param name="AllowScriptAccess" value="always" /><param name="quality" value="High" /><param name="wmode" value="transparent" /><param name="FlashVars" value="link=http%3A//180.148.142.153/clk.aspx%3Flg%3D-1%26t%3D5%26i%3D0%26b%3D56646%26s%3D1%26r%3D0%26c%3D1%26p%3D44%26n%3D0%26l%3Dhttp%253A//giaitri.vnexpress.net/tin-tuc/gioi-sao/trong-nuoc/ngo-thanh-van-mua-cung-linh-nga-trong-vet-seo-cuoc-doi-2672122.html%26uc%3D32%26uv%3Dundefined%26ud%3D1366x768%26rd%3D0.34274127264507115%26ui%3D36ad542671684be5-1-1&amp;zoneid=BasicLogo44&amp;actionTag=http%3A//180.148.142.153/act.aspx%3Ft%3D5%26i%3D0%26b%3D56646%26s%3D1%26r%3D0%26c%3D1%26p%3D44%26n%3D0%26uc%3D32%26uv%3Dundefined%26ud%3D1366x768%26rd%3D0.31978257978335023" /><embed allowscriptaccess="always" flashvars="link=http%3A//180.148.142.153/clk.aspx%3Flg%3D-1%26t%3D5%26i%3D0%26b%3D56646%26s%3D1%26r%3D0%26c%3D1%26p%3D44%26n%3D0%26l%3Dhttp%253A//giaitri.vnexpress.net/tin-tuc/gioi-sao/trong-nuoc/ngo-thanh-van-mua-cung-linh-nga-trong-vet-seo-cuoc-doi-2672122.html%26uc%3D32%26uv%3Dundefined%26ud%3D1366x768%26rd%3D0.34274127264507115%26ui%3D36ad542671684be5-1-1&amp;zoneid=BasicLogo44&amp;actionTag=http%3A//180.148.142.153/act.aspx%3Ft%3D5%26i%3D0%26b%3D56646%26s%3D1%26r%3D0%26c%3D1%26p%3D44%26n%3D0%26uc%3D32%26uv%3Dundefined%26ud%3D1366x768%26rd%3D0.31978257978335023" height="300" loop="true" play="true" pluginspage="http://www.macromedia.com/go/getflashplayer" src="http://st.polyad.net/AdImages/2013/05/09/scaroflife_180x300.swf" type="application/x-shockwave-flash" width="180" wmode="transparent"></embed></object></div>
			</div>
		</div>
		<div class="adv-header">
			&nbsp;</div>
		<div class="fl" id="BasicLogo46_available" style="margin-bottom:0;">
			<div id="BasicLogo46" style="width:180px; height:300px;">
				<object border="0" classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" codebase="http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,0,0" height="300" width="180"><param name="movie" value="http://st.polyad.net/AdImages/2013/04/26/THD_180x300_23042013.swf" /><param name="AllowScriptAccess" value="always" /><param name="quality" value="High" /><param name="wmode" value="transparent" /><param name="FlashVars" value="link=http%3A//180.148.142.153/clk.aspx%3Flg%3D-1%26t%3D5%26i%3D0%26b%3D55046%26s%3D1%26r%3D0%26c%3D1%26p%3D46%26n%3D0%26l%3Dhttp%253A//www.tdhtruongtho.com/%2523noutm%26uc%3D32%26uv%3Dundefined%26ud%3D1366x768%26rd%3D0.6725931409746408%26ui%3D36ad542671684be5-1-1&amp;zoneid=BasicLogo46&amp;actionTag=http%3A//180.148.142.153/act.aspx%3Ft%3D5%26i%3D0%26b%3D55046%26s%3D1%26r%3D0%26c%3D1%26p%3D46%26n%3D0%26uc%3D32%26uv%3Dundefined%26ud%3D1366x768%26rd%3D0.4552613813430071" /><embed allowscriptaccess="always" flashvars="link=http%3A//180.148.142.153/clk.aspx%3Flg%3D-1%26t%3D5%26i%3D0%26b%3D55046%26s%3D1%26r%3D0%26c%3D1%26p%3D46%26n%3D0%26l%3Dhttp%253A//www.tdhtruongtho.com/%2523noutm%26uc%3D32%26uv%3Dundefined%26ud%3D1366x768%26rd%3D0.6725931409746408%26ui%3D36ad542671684be5-1-1&amp;zoneid=BasicLogo46&amp;actionTag=http%3A//180.148.142.153/act.aspx%3Ft%3D5%26i%3D0%26b%3D55046%26s%3D1%26r%3D0%26c%3D1%26p%3D46%26n%3D0%26uc%3D32%26uv%3Dundefined%26ud%3D1366x768%26rd%3D0.4552613813430071" height="300" loop="true" play="true" pluginspage="http://www.macromedia.com/go/getflashplayer" src="http://st.polyad.net/AdImages/2013/04/26/THD_180x300_23042013.swf" type="application/x-shockwave-flash" width="180" wmode="transparent"></embed></object></div>
		</div>
		<div class="adv-header">
			&nbsp;</div>
		<div class="fl" id="BasicLogo50_available" style="margin-bottom:0;">
			<div id="BasicLogo50" style="width:180px; height:300px;">
				<object border="0" classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" codebase="http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,0,0" height="300" width="180"><param name="movie" value="http://st.polyad.net/AdImages/2013/05/10/BS_TU_180X300_1005.swf" /><param name="AllowScriptAccess" value="always" /><param name="quality" value="High" /><param name="wmode" value="transparent" /><param name="FlashVars" value="link=http%3A//180.148.142.153/clk.aspx%3Flg%3D-1%26t%3D5%26i%3D0%26b%3D31020%26s%3D1%26r%3D0%26c%3D1%26p%3D50%26n%3D0%26l%3Dhttp%253A//www.bacsitu.com/%26uc%3D32%26uv%3Dundefined%26ud%3D1366x768%26rd%3D0.8664248648565263%26ui%3D36ad542671684be5-1-1&amp;zoneid=BasicLogo50&amp;actionTag=http%3A//180.148.142.153/act.aspx%3Ft%3D5%26i%3D0%26b%3D31020%26s%3D1%26r%3D0%26c%3D1%26p%3D50%26n%3D0%26uc%3D32%26uv%3Dundefined%26ud%3D1366x768%26rd%3D0.7669942940119654" /><embed allowscriptaccess="always" flashvars="link=http%3A//180.148.142.153/clk.aspx%3Flg%3D-1%26t%3D5%26i%3D0%26b%3D31020%26s%3D1%26r%3D0%26c%3D1%26p%3D50%26n%3D0%26l%3Dhttp%253A//www.bacsitu.com/%26uc%3D32%26uv%3Dundefined%26ud%3D1366x768%26rd%3D0.8664248648565263%26ui%3D36ad542671684be5-1-1&amp;zoneid=BasicLogo50&amp;actionTag=http%3A//180.148.142.153/act.aspx%3Ft%3D5%26i%3D0%26b%3D31020%26s%3D1%26r%3D0%26c%3D1%26p%3D50%26n%3D0%26uc%3D32%26uv%3Dundefined%26ud%3D1366x768%26rd%3D0.7669942940119654" height="300" loop="true" play="true" pluginspage="http://www.macromedia.com/go/getflashplayer" src="http://st.polyad.net/AdImages/2013/05/10/BS_TU_180X300_1005.swf" type="application/x-shockwave-flash" width="180" wmode="transparent"></embed></object></div>
		</div>
		<div class="adv-header">
			&nbsp;</div>
		<div class="fl" id="BasicLogo51_available" style="margin-bottom:0;">
			<div id="BasicLogo51" style="width:180px; height:300px;">
				&nbsp;</div>
		</div>
		<div class="adv-header">
			&nbsp;</div>
	</div>
</div>
', N'<p>
	Contact</p>
<p>
	.....<br />
	Bui Thi Mien</p>
')
SET IDENTITY_INSERT [dbo].[Parameters] OFF
/****** Object:  Table [dbo].[NhomNguoiDung]    Script Date: 05/13/2013 23:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomNguoiDung](
	[MaNhomNguoiDung] [int] IDENTITY(1,1) NOT NULL,
	[TenNhomNguoiDung] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhomNguoiDung] PRIMARY KEY CLUSTERED 
(
	[MaNhomNguoiDung] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NhomNguoiDung] ON
INSERT [dbo].[NhomNguoiDung] ([MaNhomNguoiDung], [TenNhomNguoiDung]) VALUES (1, N'Admin')
INSERT [dbo].[NhomNguoiDung] ([MaNhomNguoiDung], [TenNhomNguoiDung]) VALUES (2, N'User')
SET IDENTITY_INSERT [dbo].[NhomNguoiDung] OFF
/****** Object:  Table [dbo].[NhaSanXuat]    Script Date: 05/13/2013 23:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaSanXuat](
	[MaNhaSanXuat] [int] IDENTITY(1,1) NOT NULL,
	[TenNhaSanXuat] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhaSanXuat] PRIMARY KEY CLUSTERED 
(
	[MaNhaSanXuat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NhaSanXuat] ON
INSERT [dbo].[NhaSanXuat] ([MaNhaSanXuat], [TenNhaSanXuat]) VALUES (1, N'Canon')
INSERT [dbo].[NhaSanXuat] ([MaNhaSanXuat], [TenNhaSanXuat]) VALUES (2, N'SamSung')
INSERT [dbo].[NhaSanXuat] ([MaNhaSanXuat], [TenNhaSanXuat]) VALUES (5, N'Fujifilm')
INSERT [dbo].[NhaSanXuat] ([MaNhaSanXuat], [TenNhaSanXuat]) VALUES (6, N'Casio')
INSERT [dbo].[NhaSanXuat] ([MaNhaSanXuat], [TenNhaSanXuat]) VALUES (7, N'Nikon')
INSERT [dbo].[NhaSanXuat] ([MaNhaSanXuat], [TenNhaSanXuat]) VALUES (8, N'Konica')
INSERT [dbo].[NhaSanXuat] ([MaNhaSanXuat], [TenNhaSanXuat]) VALUES (9, N'Sony')
INSERT [dbo].[NhaSanXuat] ([MaNhaSanXuat], [TenNhaSanXuat]) VALUES (10, N'Kodak')
INSERT [dbo].[NhaSanXuat] ([MaNhaSanXuat], [TenNhaSanXuat]) VALUES (11, N'Olympus')
SET IDENTITY_INSERT [dbo].[NhaSanXuat] OFF
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 05/13/2013 23:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[MaNguoiDung] [int] IDENTITY(1,1) NOT NULL,
	[TenNguoiDung] [nvarchar](50) NOT NULL,
	[GioiTinh] [bit] NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[DienThoai] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[NamSinh] [nchar](10) NOT NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[MaNguoiDung] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NguoiDung] ON
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [TenNguoiDung], [GioiTinh], [DiaChi], [DienThoai], [Email], [NamSinh]) VALUES (1, N'kaka', 1, N'2324', N'324234', N'234324@gmail.com', N'1234      ')
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [TenNguoiDung], [GioiTinh], [DiaChi], [DienThoai], [Email], [NamSinh]) VALUES (5, N'phuong', 1, N'cc', N'324', N'thanhphuong8k@gmail.com', N'1999      ')
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [TenNguoiDung], [GioiTinh], [DiaChi], [DienThoai], [Email], [NamSinh]) VALUES (555, N'555', 0, N'555', N'555', N'555', N'555       ')
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [TenNguoiDung], [GioiTinh], [DiaChi], [DienThoai], [Email], [NamSinh]) VALUES (888, N'phuong', 1, N'cc', N'0936334755', N'thanhphuongak@gmail.com', N'1987      ')
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [TenNguoiDung], [GioiTinh], [DiaChi], [DienThoai], [Email], [NamSinh]) VALUES (32432, N'324324', 1, N'324324', N'324324', N'324234', N'324324    ')
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [TenNguoiDung], [GioiTinh], [DiaChi], [DienThoai], [Email], [NamSinh]) VALUES (32434, N'7777', 1, N'777', N'7777', N'777', N'7777      ')
INSERT [dbo].[NguoiDung] ([MaNguoiDung], [TenNguoiDung], [GioiTinh], [DiaChi], [DienThoai], [Email], [NamSinh]) VALUES (32435, N'test 33', 0, N'3242', N'34', N'324324', N'324       ')
SET IDENTITY_INSERT [dbo].[NguoiDung] OFF
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 05/13/2013 23:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoaiSanPham] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiSanPham] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSanPham] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[LoaiSanPham] ON
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (1, N'Áo sơ mi ')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (2, N'Áo thun')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (3, N'Áo khoác')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (4, N'Đồ vest')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (5, N'Quần dài')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (6, N'Quần short')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (7, N'Đồ lót')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSanPham]) VALUES (8, N'Đồ bơi')
SET IDENTITY_INSERT [dbo].[LoaiSanPham] OFF
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 05/13/2013 23:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[MaKhuyenMai] [int] IDENTITY(1,1) NOT NULL,
	[TenKhuyenMai] [nchar](100) NOT NULL,
	[MoTa] [nvarchar](max) NOT NULL,
	[NgayBatDau] [datetime] NOT NULL,
	[NgayKetThuc] [datetime] NOT NULL,
 CONSTRAINT [PK_KhuyenMai] PRIMARY KEY CLUSTERED 
(
	[MaKhuyenMai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[KhuyenMai] ON
INSERT [dbo].[KhuyenMai] ([MaKhuyenMai], [TenKhuyenMai], [MoTa], [NgayBatDau], [NgayKetThuc]) VALUES (1, N'30-4                                                                                                ', N'<p>
	khuyen mai dat b ieta a</p>
', CAST(0x00009D2500000000 AS DateTime), CAST(0x00009D3F00000000 AS DateTime))
INSERT [dbo].[KhuyenMai] ([MaKhuyenMai], [TenKhuyenMai], [MoTa], [NgayBatDau], [NgayKetThuc]) VALUES (2, N'da                                                                                                  ', N'dsa', CAST(0x00009EF400000000 AS DateTime), CAST(0x00009EF400000000 AS DateTime))
INSERT [dbo].[KhuyenMai] ([MaKhuyenMai], [TenKhuyenMai], [MoTa], [NgayBatDau], [NgayKetThuc]) VALUES (5, N'thu ngheim                                                                                          ', N'<p><div style="color:red;">	dsafsdafsdf</div></p>', CAST(0x00009EEC00000000 AS DateTime), CAST(0x00009EF400000000 AS DateTime))
INSERT [dbo].[KhuyenMai] ([MaKhuyenMai], [TenKhuyenMai], [MoTa], [NgayBatDau], [NgayKetThuc]) VALUES (6, N'Khuyen mai he 2011                                                                                  ', N'<p> 	Ra mắt cuối năm 2010, Desire HD nhanh ch&oacute;ng thu h&uacute;t được sự ch&uacute; &yacute; của c&aacute;c doanh nh&acirc;n. Một thiết kế dựa tr&ecirc;n cấu tr&uacute;c của chiếc HD2, tuy nhi&ecirc;n Desire HD được trang bị hệ điều h&agrave;nh mới Android 2.2 Froyo với giao diện Sense v&agrave; bộ xử l&yacute; tốc độ 1GHz Snapdragon.<br /> 	HTC Desire HD đ&atilde; bắt đầu b&aacute;n ra thị trường Việt Nam ở mức gi&aacute; 14,440 triệu đồng, l&agrave; một thiết bị đ&aacute;ng chọn ở tầm gi&aacute; cao. Desire HD được xem l&agrave; model &quot;trả đũa&quot; cho tham vọng truất ng&ocirc;i của Samsung tr&ecirc;n l&atilde;nh địa điện thoại Android. Trước đ&oacute;, Samsung đ&atilde; tr&igrave;nh diễn chiếc Galaxy S I9000 với đồ họa si&ecirc;u mạnh v&agrave; nhiều trang bị mạnh mẽ.<br /> 	<em>Một v&agrave;i h&igrave;nh ảnh của HTC Desire HD:</em></p>', CAST(0x00009EDE00000000 AS DateTime), CAST(0x00009EEE00000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[KhuyenMai] OFF
/****** Object:  Table [dbo].[DongSanPham]    Script Date: 05/13/2013 23:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DongSanPham](
	[MaDongSanPham] [int] IDENTITY(1,1) NOT NULL,
	[MaNhaSanXuat] [int] NULL,
	[TenDongSanPham] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DongSanPham] PRIMARY KEY CLUSTERED 
(
	[MaDongSanPham] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DongSanPham] ON
INSERT [dbo].[DongSanPham] ([MaDongSanPham], [MaNhaSanXuat], [TenDongSanPham]) VALUES (1, 1, N'powersort')
INSERT [dbo].[DongSanPham] ([MaDongSanPham], [MaNhaSanXuat], [TenDongSanPham]) VALUES (2, 2, N' NX Series')
SET IDENTITY_INSERT [dbo].[DongSanPham] OFF
/****** Object:  Table [dbo].[DonDatHang]    Script Date: 05/13/2013 23:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonDatHang](
	[MaDonDatHang] [int] IDENTITY(1,1) NOT NULL,
	[MaNguoiDung] [int] NOT NULL,
	[NgayLap] [datetime] NOT NULL,
	[ThueSuat] [int] NOT NULL,
	[TongTien] [money] NOT NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_DonDatHang] PRIMARY KEY CLUSTERED 
(
	[MaDonDatHang] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 05/13/2013 23:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[Username] [nchar](10) NOT NULL,
	[Password] [nchar](10) NOT NULL,
	[MaNguoiDung] [int] NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[ThoiGianDangNhap] [datetime] NOT NULL,
	[CauHoiBaoMat] [nvarchar](100) NOT NULL,
	[TraLoiCauHoiBaoMat] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_TaiKhoan_1] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TaiKhoan] ([Username], [Password], [MaNguoiDung], [NgayTao], [ThoiGianDangNhap], [CauHoiBaoMat], [TraLoiCauHoiBaoMat]) VALUES (N'324324    ', N'34324     ', 32432, CAST(0x00009EE700000000 AS DateTime), CAST(0x00009EE700000000 AS DateTime), N'324', N'324')
INSERT [dbo].[TaiKhoan] ([Username], [Password], [MaNguoiDung], [NgayTao], [ThoiGianDangNhap], [CauHoiBaoMat], [TraLoiCauHoiBaoMat]) VALUES (N'phuongnt  ', N'create    ', 5, CAST(0x00009D1300000000 AS DateTime), CAST(0x00009D1300000000 AS DateTime), N'your name?', N'phuong')
INSERT [dbo].[TaiKhoan] ([Username], [Password], [MaNguoiDung], [NgayTao], [ThoiGianDangNhap], [CauHoiBaoMat], [TraLoiCauHoiBaoMat]) VALUES (N'tram      ', N'tram      ', 32435, CAST(0x00009FEB00000000 AS DateTime), CAST(0x00009FEB00000000 AS DateTime), N'tao la ai', N'may la ai')
/****** Object:  Table [dbo].[TinTuc]    Script Date: 05/13/2013 23:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinTuc](
	[MaTinTuc] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nchar](10) NOT NULL,
	[TieuDe] [nvarchar](100) NOT NULL,
	[NoiDung] [nvarchar](max) NOT NULL,
	[NgayDang] [datetime] NOT NULL,
 CONSTRAINT [PK_BaiViet] PRIMARY KEY CLUSTERED 
(
	[MaTinTuc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TinTuc] ON
INSERT [dbo].[TinTuc] ([MaTinTuc], [Username], [TieuDe], [NoiDung], [NgayDang]) VALUES (3, N'phuongnt  ', N'435', N'<p>
	34535</p>
', CAST(0x00009EE400000000 AS DateTime))
INSERT [dbo].[TinTuc] ([MaTinTuc], [Username], [TieuDe], [NoiDung], [NgayDang]) VALUES (4, N'phuongnt  ', N'dsaf', N'<p>
	dsaf</p>
', CAST(0x00009EE400000000 AS DateTime))
SET IDENTITY_INSERT [dbo].[TinTuc] OFF
/****** Object:  Table [dbo].[SanPham]    Script Date: 05/13/2013 23:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSanPham] [int] IDENTITY(1,1) NOT NULL,
	[MaDongSanPham] [int] NOT NULL,
	[MaLoaiSanPham] [int] NOT NULL,
	[MaKhuyenMai] [int] NOT NULL,
	[TenSanPham] [nvarchar](100) NOT NULL,
	[GiaBan] [money] NOT NULL,
	[NgayDang] [datetime] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[TinhTrang] [bit] NULL,
	[Description] [nvarchar](max) NULL,
	[IsNew] [bit] NULL,
	[IsHot] [bit] NULL,
	[Percent] [int] NULL,
	[Gia2] [money] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SanPham] ON
INSERT [dbo].[SanPham] ([MaSanPham], [MaDongSanPham], [MaLoaiSanPham], [MaKhuyenMai], [TenSanPham], [GiaBan], [NgayDang], [SoLuong], [TinhTrang], [Description], [IsNew], [IsHot], [Percent], [Gia2]) VALUES (29, 1, 1, 1, N'Ao so mi han quoc', 100000.0000, CAST(0x0000A1BD016FB29D AS DateTime), 3, 1, N'<p>
	xxxxxxxxxxxxxxxd</p>
<p>
	sf</p>
<p>
	dsf</p>
<p>
	ds</p>
<p>
	fs</p>
<p>
	fd</p>
<p>
	&nbsp;</p>
', 1, 0, 3, 150000.0000)
INSERT [dbo].[SanPham] ([MaSanPham], [MaDongSanPham], [MaLoaiSanPham], [MaKhuyenMai], [TenSanPham], [GiaBan], [NgayDang], [SoLuong], [TinhTrang], [Description], [IsNew], [IsHot], [Percent], [Gia2]) VALUES (30, 1, 3, 1, N'Áo khoắc HQ', 500000.0000, CAST(0x0000A1A701774148 AS DateTime), 100, 1, N'<div id="lipsum">
	<p>
		Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus volutpat tempus rutrum. Phasellus at ipsum ac quam volutpat facilisis vitae eu mauris. Nulla nunc nunc, commodo a laoreet a, scelerisque id nunc. Suspendisse fermentum tortor sit amet risus posuere laoreet. Nunc diam eros, porta vel posuere ac, tempor ut lacus. Donec pretium laoreet bibendum. Proin sollicitudin est ac elit semper mollis. Vivamus mattis mauris id lacus bibendum at vulputate elit lacinia. Proin sit amet est a magna convallis tristique. In eget vestibulum ipsum. In ipsum turpis, malesuada quis malesuada non, tempor non ligula. Fusce sit amet nisl non sem sagittis viverra. Maecenas auctor vehicula augue, sit amet congue orci venenatis eget. Donec a lacus tortor.</p>
	<p>
		Nunc enim libero, consectetur sed pharetra eget, aliquet nec est. Cras porttitor dolor et quam venenatis id convallis erat ornare. Sed aliquam eleifend orci, vel venenatis arcu adipiscing eu. Nulla varius feugiat quam et vestibulum. Maecenas sed ullamcorper lorem. Fusce vitae odio et urna accumsan tempus in et risus. Duis molestie tincidunt molestie. Praesent vel leo metus, euismod iaculis massa. Pellentesque fringilla convallis dui, in vehicula erat consequat ac. Nullam non felis purus. Etiam eget enim urna. Nunc interdum auctor lorem, nec mattis tellus cursus eget. Pellentesque augue metus, pulvinar et rhoncus nec, laoreet commodo arcu. Nam euismod hendrerit nulla vel scelerisque. Aenean euismod aliquam erat non fermentum. Aliquam dignissim, arcu elementum convallis euismod, sapien diam dictum enim, a accumsan metus dui eu erat.</p>
	<p>
		Nullam rhoncus est in dolor mattis id condimentum magna facilisis. Morbi eu lobortis dolor. Nulla semper, quam sed pretium vulputate, ligula magna eleifend justo, in fringilla dui ligula ut metus. Donec porta massa quis odio hendrerit a tempus quam semper. Mauris semper imperdiet massa et fringilla. Vestibulum et metus in mi accumsan pretium. Aenean quis sem sem. In erat nibh, dictum ac pretium sed, sollicitudin ut nulla. Suspendisse placerat fermentum nibh, at mollis sapien gravida ac. Proin a metus et arcu pellentesque convallis. Nulla sed molestie lacus. Curabitur fermentum bibendum venenatis.</p>
	<p>
		Morbi dapibus aliquam fringilla. Donec leo nunc, rhoncus id luctus eget, mattis sit amet lectus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Etiam viverra mauris sed ante suscipit nec sollicitudin dui ornare. Maecenas interdum vestibulum commodo. Vivamus quis risus ac justo suscipit lobortis. In nec ante vitae metus pretium convallis sit amet vitae eros. Nulla facilisi. Pellentesque mauris sem, semper sed vehicula sit amet, imperdiet at ante. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin fringilla pharetra ipsum, id porta erat tempor nec. Pellentesque et quam nisi, vel condimentum mi. Nulla gravida imperdiet lacus.</p>
	<p>
		Fusce laoreet mi sed magna interdum vestibulum. Praesent accumsan interdum lorem, at suscipit nisi commodo ut. Donec leo elit, tincidunt eget vestibulum vitae, aliquet vel est. Etiam porttitor, ipsum vitae aliquet dignissim, felis sapien varius massa, id accumsan tellus tortor laoreet odio. Etiam imperdiet, metus in tristique iaculis, metus nisl feugiat sapien, eu sodales ligula sapien eu neque. Nam tincidunt varius imperdiet. Duis neque diam, eleifend quis porttitor ac, scelerisque eu nibh.</p>
</div>
<div id="generated">
	Generated 5 paragraphs, 503 words, 3378 bytes of <a href="http://www.lipsum.com/" title="Lorem Ipsum">Lorem Ipsum</a></div>
', 0, 0, NULL, 0.0000)
INSERT [dbo].[SanPham] ([MaSanPham], [MaDongSanPham], [MaLoaiSanPham], [MaKhuyenMai], [TenSanPham], [GiaBan], [NgayDang], [SoLuong], [TinhTrang], [Description], [IsNew], [IsHot], [Percent], [Gia2]) VALUES (31, 1, 3, 1, N'Áo khoác 1', 600000.0000, CAST(0x0000A1A70178311D AS DateTime), 60, 1, N'<p>
	<br />
	<br />
	Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus volutpat tempus rutrum. Phasellus at ipsum ac quam volutpat facilisis vitae eu mauris. Nulla nunc nunc, commodo a laoreet a, scelerisque id nunc. Suspendisse fermentum tortor sit amet risus posuere laoreet. Nunc diam eros, porta vel posuere ac, tempor ut lacus. Donec pretium laoreet bibendum. Proin sollicitudin est ac elit semper mollis. Vivamus mattis mauris id lacus bibendum at vulputate elit lacinia. Proin sit amet est a magna convallis tristique. In eget vestibulum ipsum. In ipsum turpis, malesuada quis malesuada non, tempor non ligula. Fusce sit amet nisl non sem sagittis viverra. Maecenas auctor vehicula augue, sit amet congue orci venenatis eget. Donec a lacus tortor.<br />
	<br />
	Nunc enim libero, consectetur sed pharetra eget, aliquet nec est. Cras porttitor dolor et quam venenatis id convallis erat ornare. Sed aliquam eleifend orci, vel venenatis arcu adipiscing eu. Nulla varius feugiat quam et vestibulum. Maecenas sed ullamcorper lorem. Fusce vitae odio et urna accumsan tempus in et risus. Duis molestie tincidunt molestie. Praesent vel leo metus, euismod iaculis massa. Pellentesque fringilla convallis dui, in vehicula erat consequat ac. Nullam non felis purus. Etiam eget enim urna. Nunc interdum auctor lorem, nec mattis tellus cursus eget. Pellentesque augue metus, pulvinar et rhoncus nec, laoreet commodo arcu. Nam euismod hendrerit nulla vel scelerisque. Aenean euismod aliquam erat non fermentum. Aliquam dignissim, arcu elementum convallis euismod, sapien diam dictum enim, a accumsan metus dui eu erat.<br />
	<br />
	Nullam rhoncus est in dolor mattis id condimentum magna facilisis. Morbi eu lobortis dolor. Nulla semper, quam sed pretium vulputate, ligula magna eleifend justo, in fringilla dui ligula ut metus. Donec porta massa quis odio hendrerit a tempus quam semper. Mauris semper imperdiet massa et fringilla. Vestibulum et metus in mi accumsan pretium. Aenean quis sem sem. In erat nibh, dictum ac pretium sed, sollicitudin ut nulla. Suspendisse placerat fermentum nibh, at mollis sapien gravida ac. Proin a metus et arcu pellentesque convallis. Nulla sed molestie lacus. Curabitur fermentum bibendum venenatis.<br />
	<br />
	Morbi dapibus aliquam fringilla. Donec leo nunc, rhoncus id luctus eget, mattis sit amet lectus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Etiam viverra mauris sed ante suscipit nec sollicitudin dui ornare. Maecenas interdum vestibulum commodo. Vivamus quis risus ac justo suscipit lobortis. In nec ante vitae metus pretium convallis sit amet vitae eros. Nulla facilisi. Pellentesque mauris sem, semper sed vehicula sit amet, imperdiet at ante. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin fringilla pharetra ipsum, id porta erat tempor nec. Pellentesque et quam nisi, vel condimentum mi. Nulla gravida imperdiet lacus.<br />
	<br />
	Fusce laoreet mi sed magna interdum vestibulum. Praesent accumsan interdum lorem, at suscipit nisi commodo ut. Donec leo elit, tincidunt eget vestibulum vitae, aliquet vel est. Etiam porttitor, ipsum vitae aliquet dignissim, felis sapien varius massa, id accumsan tellus tortor laoreet odio. Etiam imperdiet, metus in tristique iaculis, metus nisl feugiat sapien, eu sodales ligula sapien eu neque. Nam tincidunt varius imperdiet. Duis neque diam, eleifend quis porttitor ac, scelerisque eu nibh.<br />
	Generated 5 paragraphs, 503 words, 3378 bytes of Lorem Ipsum</p>
', 0, 0, NULL, 0.0000)
INSERT [dbo].[SanPham] ([MaSanPham], [MaDongSanPham], [MaLoaiSanPham], [MaKhuyenMai], [TenSanPham], [GiaBan], [NgayDang], [SoLuong], [TinhTrang], [Description], [IsNew], [IsHot], [Percent], [Gia2]) VALUES (32, 1, 1, 1, N'So mi 1x', 300000.0000, CAST(0x0000A1BD00119D32 AS DateTime), 600, 1, N'<p>
	<br />
	<br />
	Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus volutpat tempus rutrum. Phasellus at ipsum ac quam volutpat facilisis vitae eu mauris. Nulla nunc nunc, commodo a laoreet a, scelerisque id nunc. Suspendisse fermentum tortor sit amet risus posuere laoreet. Nunc diam eros, porta vel posuere ac, tempor ut lacus. Donec pretium laoreet bibendum. Proin sollicitudin est ac elit semper mollis. Vivamus mattis mauris id lacus bibendum at vulputate elit lacinia. Proin sit amet est a magna convallis tristique. In eget vestibulum ipsum. In ipsum turpis, malesuada quis malesuada non, tempor non ligula. Fusce sit amet nisl non sem sagittis viverra. Maecenas auctor vehicula augue, sit amet congue orci venenatis eget. Donec a lacus tortor.<br />
	<br />
	Nunc enim libero, consectetur sed pharetra eget, aliquet nec est. Cras porttitor dolor et quam venenatis id convallis erat ornare. Sed aliquam eleifend orci, vel venenatis arcu adipiscing eu. Nulla varius feugiat quam et vestibulum. Maecenas sed ullamcorper lorem. Fusce vitae odio et urna accumsan tempus in et risus. Duis molestie tincidunt molestie. Praesent vel leo metus, euismod iaculis massa. Pellentesque fringilla convallis dui, in vehicula erat consequat ac. Nullam non felis purus. Etiam eget enim urna. Nunc interdum auctor lorem, nec mattis tellus cursus eget. Pellentesque augue metus, pulvinar et rhoncus nec, laoreet commodo arcu. Nam euismod hendrerit nulla vel scelerisque. Aenean euismod aliquam erat non fermentum. Aliquam dignissim, arcu elementum convallis euismod, sapien diam dictum enim, a accumsan metus dui eu erat.<br />
	<br />
	Nullam rhoncus est in dolor mattis id condimentum magna facilisis. Morbi eu lobortis dolor. Nulla semper, quam sed pretium vulputate, ligula magna eleifend justo, in fringilla dui ligula ut metus. Donec porta massa quis odio hendrerit a tempus quam semper. Mauris semper imperdiet massa et fringilla. Vestibulum et metus in mi accumsan pretium. Aenean quis sem sem. In erat nibh, dictum ac pretium sed, sollicitudin ut nulla. Suspendisse placerat fermentum nibh, at mollis sapien gravida ac. Proin a metus et arcu pellentesque convallis. Nulla sed molestie lacus. Curabitur fermentum bibendum venenatis.<br />
	<br />
	Morbi dapibus aliquam fringilla. Donec leo nunc, rhoncus id luctus eget, mattis sit amet lectus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Etiam viverra mauris sed ante suscipit nec sollicitudin dui ornare. Maecenas interdum vestibulum commodo. Vivamus quis risus ac justo suscipit lobortis. In nec ante vitae metus pretium convallis sit amet vitae eros. Nulla facilisi. Pellentesque mauris sem, semper sed vehicula sit amet, imperdiet at ante. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin fringilla pharetra ipsum, id porta erat tempor nec. Pellentesque et quam nisi, vel condimentum mi. Nulla gravida imperdiet lacus.<br />
	<br />
	Fusce laoreet mi sed magna interdum vestibulum. Praesent accumsan interdum lorem, at suscipit nisi commodo ut. Donec leo elit, tincidunt eget vestibulum vitae, aliquet vel est. Etiam porttitor, ipsum vitae aliquet dignissim, felis sapien varius massa, id accumsan tellus tortor laoreet odio. Etiam imperdiet, metus in tristique iaculis, metus nisl feugiat sapien, eu sodales ligula sapien eu neque. Nam tincidunt varius imperdiet. Duis neque diam, eleifend quis porttitor ac, scelerisque eu nibh.<br />
	Generated 5 paragraphs, 503 words, 3378 bytes of Lorem Ipsum</p>
', 1, 1, 35, 0.0000)
INSERT [dbo].[SanPham] ([MaSanPham], [MaDongSanPham], [MaLoaiSanPham], [MaKhuyenMai], [TenSanPham], [GiaBan], [NgayDang], [SoLuong], [TinhTrang], [Description], [IsNew], [IsHot], [Percent], [Gia2]) VALUES (37, 1, 1, 1, N'dsaf', 333.0000, CAST(0x0000A1BD016FD7ED AS DateTime), 33, NULL, N'<p>
	xxx</p>
', 1, 1, 12, 0.0000)
SET IDENTITY_INSERT [dbo].[SanPham] OFF
/****** Object:  Table [dbo].[HoaDon]    Script Date: 05/13/2013 23:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[MaDonDatHang] [int] NOT NULL,
	[MaNhanVien] [int] NOT NULL,
	[NgayLap] [datetime] NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietNhomNguoiDung]    Script Date: 05/13/2013 23:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietNhomNguoiDung](
	[Username] [nchar](10) NOT NULL,
	[MaNhomNguoiDung] [int] NOT NULL,
	[MoTa] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_ChiTietNhomNguoiDung] PRIMARY KEY CLUSTERED 
(
	[Username] ASC,
	[MaNhomNguoiDung] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietNhomNguoiDung] ([Username], [MaNhomNguoiDung], [MoTa]) VALUES (N'324324    ', 1, N'ko co j')
INSERT [dbo].[ChiTietNhomNguoiDung] ([Username], [MaNhomNguoiDung], [MoTa]) VALUES (N'phuongnt  ', 1, N'2')
INSERT [dbo].[ChiTietNhomNguoiDung] ([Username], [MaNhomNguoiDung], [MoTa]) VALUES (N'phuongnt  ', 2, N'ko co j')
INSERT [dbo].[ChiTietNhomNguoiDung] ([Username], [MaNhomNguoiDung], [MoTa]) VALUES (N'tram      ', 1, N'ko co j')
/****** Object:  Table [dbo].[ChiTietThongSo]    Script Date: 05/13/2013 23:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietThongSo](
	[MaThongSo] [int] NOT NULL,
	[MaSanPham] [int] NOT NULL,
	[GiaTri] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_ChiTietThongSo] PRIMARY KEY CLUSTERED 
(
	[MaThongSo] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietThongSo] ([MaThongSo], [MaSanPham], [GiaTri]) VALUES (1, 29, N'Sọc đen trắng')
INSERT [dbo].[ChiTietThongSo] ([MaThongSo], [MaSanPham], [GiaTri]) VALUES (1, 30, N'Đen')
INSERT [dbo].[ChiTietThongSo] ([MaThongSo], [MaSanPham], [GiaTri]) VALUES (1, 31, N'Đen')
INSERT [dbo].[ChiTietThongSo] ([MaThongSo], [MaSanPham], [GiaTri]) VALUES (1, 32, N'Trắng')
INSERT [dbo].[ChiTietThongSo] ([MaThongSo], [MaSanPham], [GiaTri]) VALUES (1, 37, N'32')
INSERT [dbo].[ChiTietThongSo] ([MaThongSo], [MaSanPham], [GiaTri]) VALUES (2, 29, N'S,M, XL')
INSERT [dbo].[ChiTietThongSo] ([MaThongSo], [MaSanPham], [GiaTri]) VALUES (2, 30, N'S, M')
INSERT [dbo].[ChiTietThongSo] ([MaThongSo], [MaSanPham], [GiaTri]) VALUES (2, 31, N'S,M, XL')
INSERT [dbo].[ChiTietThongSo] ([MaThongSo], [MaSanPham], [GiaTri]) VALUES (2, 32, N'xl')
INSERT [dbo].[ChiTietThongSo] ([MaThongSo], [MaSanPham], [GiaTri]) VALUES (2, 37, N'3')
INSERT [dbo].[ChiTietThongSo] ([MaThongSo], [MaSanPham], [GiaTri]) VALUES (3, 29, N'Thun')
INSERT [dbo].[ChiTietThongSo] ([MaThongSo], [MaSanPham], [GiaTri]) VALUES (3, 30, N'Da')
INSERT [dbo].[ChiTietThongSo] ([MaThongSo], [MaSanPham], [GiaTri]) VALUES (3, 31, N'ABC')
INSERT [dbo].[ChiTietThongSo] ([MaThongSo], [MaSanPham], [GiaTri]) VALUES (3, 32, N'cotton')
INSERT [dbo].[ChiTietThongSo] ([MaThongSo], [MaSanPham], [GiaTri]) VALUES (3, 37, N'3')
INSERT [dbo].[ChiTietThongSo] ([MaThongSo], [MaSanPham], [GiaTri]) VALUES (4, 29, N'HQ')
INSERT [dbo].[ChiTietThongSo] ([MaThongSo], [MaSanPham], [GiaTri]) VALUES (4, 30, N'HQ')
INSERT [dbo].[ChiTietThongSo] ([MaThongSo], [MaSanPham], [GiaTri]) VALUES (4, 31, N'BCD')
INSERT [dbo].[ChiTietThongSo] ([MaThongSo], [MaSanPham], [GiaTri]) VALUES (4, 32, N'Cong so')
INSERT [dbo].[ChiTietThongSo] ([MaThongSo], [MaSanPham], [GiaTri]) VALUES (4, 37, N'3')
/****** Object:  Table [dbo].[ChiTietDonDatHang]    Script Date: 05/13/2013 23:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonDatHang](
	[MaDonDatHang] [int] NOT NULL,
	[MaSanPham] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [money] NOT NULL,
	[ThanhTien] [money] NOT NULL,
 CONSTRAINT [PK_ChiTietDonDatHang] PRIMARY KEY CLUSTERED 
(
	[MaDonDatHang] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cart]    Script Date: 05/13/2013 23:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cart](
	[RecordID] [int] IDENTITY(1,1) NOT NULL,
	[CartID] [nvarchar](128) NOT NULL,
	[MaSanPham] [int] NOT NULL,
	[Count] [int] NOT NULL,
	[DateCreate] [datetime] NULL,
 CONSTRAINT [PK_Cart] PRIMARY KEY CLUSTERED 
(
	[RecordID] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnhSanPham]    Script Date: 05/13/2013 23:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnhSanPham](
	[MaHinhAnh] [int] IDENTITY(1,1) NOT NULL,
	[URL] [nvarchar](200) NOT NULL,
	[MaSanPham] [int] NOT NULL,
 CONSTRAINT [PK_AnhSanPham] PRIMARY KEY CLUSTERED 
(
	[MaHinhAnh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AnhSanPham] ON
INSERT [dbo].[AnhSanPham] ([MaHinhAnh], [URL], [MaSanPham]) VALUES (40, N'/upload/ao-thun-doc-nang_1_.jpg', 29)
INSERT [dbo].[AnhSanPham] ([MaHinhAnh], [URL], [MaSanPham]) VALUES (42, N'/upload/ao-thun-doc-nang_4_.jpg', 29)
INSERT [dbo].[AnhSanPham] ([MaHinhAnh], [URL], [MaSanPham]) VALUES (43, N'/upload/ao-thun-doc-nang_5_.jpg', 29)
INSERT [dbo].[AnhSanPham] ([MaHinhAnh], [URL], [MaSanPham]) VALUES (45, N'/upload/k1.jpg', 31)
INSERT [dbo].[AnhSanPham] ([MaHinhAnh], [URL], [MaSanPham]) VALUES (46, N'/upload/k2.jpg', 31)
INSERT [dbo].[AnhSanPham] ([MaHinhAnh], [URL], [MaSanPham]) VALUES (47, N'/upload/a1 (2).jpg', 30)
INSERT [dbo].[AnhSanPham] ([MaHinhAnh], [URL], [MaSanPham]) VALUES (48, N'/upload/a2.jpg', 30)
INSERT [dbo].[AnhSanPham] ([MaHinhAnh], [URL], [MaSanPham]) VALUES (51, N'/upload/s3.jpg', 32)
INSERT [dbo].[AnhSanPham] ([MaHinhAnh], [URL], [MaSanPham]) VALUES (52, N'/upload/s4.jpg', 32)
SET IDENTITY_INSERT [dbo].[AnhSanPham] OFF
/****** Object:  ForeignKey [FK_AnhSanPham_SanPham]    Script Date: 05/13/2013 23:05:39 ******/
ALTER TABLE [dbo].[AnhSanPham]  WITH CHECK ADD  CONSTRAINT [FK_AnhSanPham_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AnhSanPham] CHECK CONSTRAINT [FK_AnhSanPham_SanPham]
GO
/****** Object:  ForeignKey [FK_Cart_SanPham]    Script Date: 05/13/2013 23:05:39 ******/
ALTER TABLE [dbo].[Cart]  WITH CHECK ADD  CONSTRAINT [FK_Cart_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[Cart] CHECK CONSTRAINT [FK_Cart_SanPham]
GO
/****** Object:  ForeignKey [FK_ChiTietDonDatHang_DonDatHang]    Script Date: 05/13/2013 23:05:39 ******/
ALTER TABLE [dbo].[ChiTietDonDatHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonDatHang_DonDatHang] FOREIGN KEY([MaDonDatHang])
REFERENCES [dbo].[DonDatHang] ([MaDonDatHang])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietDonDatHang] CHECK CONSTRAINT [FK_ChiTietDonDatHang_DonDatHang]
GO
/****** Object:  ForeignKey [FK_ChiTietDonDatHang_SanPham]    Script Date: 05/13/2013 23:05:39 ******/
ALTER TABLE [dbo].[ChiTietDonDatHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonDatHang_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietDonDatHang] CHECK CONSTRAINT [FK_ChiTietDonDatHang_SanPham]
GO
/****** Object:  ForeignKey [FK_ChiTietNhomNguoiDung_NhomNguoiDung]    Script Date: 05/13/2013 23:05:39 ******/
ALTER TABLE [dbo].[ChiTietNhomNguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietNhomNguoiDung_NhomNguoiDung] FOREIGN KEY([MaNhomNguoiDung])
REFERENCES [dbo].[NhomNguoiDung] ([MaNhomNguoiDung])
GO
ALTER TABLE [dbo].[ChiTietNhomNguoiDung] CHECK CONSTRAINT [FK_ChiTietNhomNguoiDung_NhomNguoiDung]
GO
/****** Object:  ForeignKey [FK_ChiTietNhomNguoiDung_TaiKhoan1]    Script Date: 05/13/2013 23:05:39 ******/
ALTER TABLE [dbo].[ChiTietNhomNguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietNhomNguoiDung_TaiKhoan1] FOREIGN KEY([Username])
REFERENCES [dbo].[TaiKhoan] ([Username])
GO
ALTER TABLE [dbo].[ChiTietNhomNguoiDung] CHECK CONSTRAINT [FK_ChiTietNhomNguoiDung_TaiKhoan1]
GO
/****** Object:  ForeignKey [FK_ChiTietThongSo_SanPham]    Script Date: 05/13/2013 23:05:39 ******/
ALTER TABLE [dbo].[ChiTietThongSo]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietThongSo_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietThongSo] CHECK CONSTRAINT [FK_ChiTietThongSo_SanPham]
GO
/****** Object:  ForeignKey [FK_ChiTietThongSo_ThongSo]    Script Date: 05/13/2013 23:05:39 ******/
ALTER TABLE [dbo].[ChiTietThongSo]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietThongSo_ThongSo] FOREIGN KEY([MaThongSo])
REFERENCES [dbo].[ThongSo] ([MaThongSo])
GO
ALTER TABLE [dbo].[ChiTietThongSo] CHECK CONSTRAINT [FK_ChiTietThongSo_ThongSo]
GO
/****** Object:  ForeignKey [FK_DonDatHang_NguoiDung]    Script Date: 05/13/2013 23:05:39 ******/
ALTER TABLE [dbo].[DonDatHang]  WITH CHECK ADD  CONSTRAINT [FK_DonDatHang_NguoiDung] FOREIGN KEY([MaNguoiDung])
REFERENCES [dbo].[NguoiDung] ([MaNguoiDung])
GO
ALTER TABLE [dbo].[DonDatHang] CHECK CONSTRAINT [FK_DonDatHang_NguoiDung]
GO
/****** Object:  ForeignKey [FK_DongSanPham_NhaSanXuat]    Script Date: 05/13/2013 23:05:39 ******/
ALTER TABLE [dbo].[DongSanPham]  WITH CHECK ADD  CONSTRAINT [FK_DongSanPham_NhaSanXuat] FOREIGN KEY([MaNhaSanXuat])
REFERENCES [dbo].[NhaSanXuat] ([MaNhaSanXuat])
GO
ALTER TABLE [dbo].[DongSanPham] CHECK CONSTRAINT [FK_DongSanPham_NhaSanXuat]
GO
/****** Object:  ForeignKey [FK_HoaDon_DonDatHang]    Script Date: 05/13/2013 23:05:39 ******/
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_DonDatHang] FOREIGN KEY([MaDonDatHang])
REFERENCES [dbo].[DonDatHang] ([MaDonDatHang])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_DonDatHang]
GO
/****** Object:  ForeignKey [FK_HoaDon_NguoiDung]    Script Date: 05/13/2013 23:05:39 ******/
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NguoiDung] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NguoiDung] ([MaNguoiDung])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NguoiDung]
GO
/****** Object:  ForeignKey [FK_SanPham_DongSanPham]    Script Date: 05/13/2013 23:05:39 ******/
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_DongSanPham] FOREIGN KEY([MaDongSanPham])
REFERENCES [dbo].[DongSanPham] ([MaDongSanPham])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_DongSanPham]
GO
/****** Object:  ForeignKey [FK_SanPham_KhuyenMai]    Script Date: 05/13/2013 23:05:39 ******/
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_KhuyenMai] FOREIGN KEY([MaKhuyenMai])
REFERENCES [dbo].[KhuyenMai] ([MaKhuyenMai])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_KhuyenMai]
GO
/****** Object:  ForeignKey [FK_SanPham_LoaiSanPham]    Script Date: 05/13/2013 23:05:39 ******/
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSanPham] FOREIGN KEY([MaLoaiSanPham])
REFERENCES [dbo].[LoaiSanPham] ([MaLoaiSanPham])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSanPham]
GO
/****** Object:  ForeignKey [FK_TaiKhoan_NguoiDung]    Script Date: 05/13/2013 23:05:39 ******/
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NguoiDung] FOREIGN KEY([MaNguoiDung])
REFERENCES [dbo].[NguoiDung] ([MaNguoiDung])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NguoiDung]
GO
/****** Object:  ForeignKey [FK_TinTuc_TaiKhoan]    Script Date: 05/13/2013 23:05:39 ******/
ALTER TABLE [dbo].[TinTuc]  WITH CHECK ADD  CONSTRAINT [FK_TinTuc_TaiKhoan] FOREIGN KEY([Username])
REFERENCES [dbo].[TaiKhoan] ([Username])
GO
ALTER TABLE [dbo].[TinTuc] CHECK CONSTRAINT [FK_TinTuc_TaiKhoan]
GO
