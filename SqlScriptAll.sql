USE [ABC_bakery]
GO
/****** Object:  UserDefinedFunction [dbo].[SumOfColumn]    Script Date: 12/9/2023 9:55:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[SumOfColumn]
(
    @TableName NVARCHAR(255),
    @ColumnName NVARCHAR(255)
)
RETURNS INT
AS
BEGIN
    DECLARE @DynamicSQL NVARCHAR(MAX);
    DECLARE @Total INT;

    -- Xây dựng câu truy vấn động để tính tổng
    SET @DynamicSQL = 'SELECT @Total = SUM(' + QUOTENAME(@ColumnName) + ') FROM ' + QUOTENAME(@TableName);

    -- Thực hiện câu truy vấn động và lấy kết quả tổng
    EXEC sp_executesql @DynamicSQL, N'@Total INT OUTPUT', @Total OUTPUT;

    RETURN @Total;
END;
GO
/****** Object:  Table [dbo].[categories]    Script Date: 12/9/2023 9:55:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categories](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[prefix] [nvarchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chi]    Script Date: 12/9/2023 9:55:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](250) NULL,
	[quantity] [int] NULL,
	[price] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[images]    Script Date: 12/9/2023 9:55:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[images](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[product_id] [bigint] NOT NULL,
	[url] [varchar](512) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[import_product]    Script Date: 12/9/2023 9:55:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[import_product](
	[import_id] [bigint] NOT NULL,
	[product_id] [bigint] NOT NULL,
	[price] [float] NOT NULL,
	[amount] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[import_id] ASC,
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[imports]    Script Date: 12/9/2023 9:55:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[imports](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[supplier_id] [bigint] NOT NULL,
	[admin_id] [bigint] NOT NULL,
	[total] [int] NOT NULL,
	[created_at] [date] NOT NULL,
	[is_inter] [bit] NOT NULL,
	[prefix] [nvarchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order_detail]    Script Date: 12/9/2023 9:55:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order_detail](
	[order_id] [nchar](10) NULL,
	[product_id] [nchar](10) NULL,
	[price] [float] NULL,
	[total] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 12/9/2023 9:55:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[promotion_id] [bigint] NULL,
	[receipt_id] [bigint] NOT NULL,
	[cashier_id] [bigint] NOT NULL,
	[price] [float] NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[address] [nvarchar](512) NOT NULL,
	[status] [int] NOT NULL,
	[type] [int] NOT NULL,
	[total] [int] NOT NULL,
	[ship_fee] [float] NOT NULL,
	[payment_method] [int] NOT NULL,
	[is_paid] [bit] NOT NULL,
	[prepay] [float] NOT NULL,
	[ordered_at] [date] NOT NULL,
	[note] [text] NOT NULL,
	[change] [int] NOT NULL,
	[receieved] [int] NOT NULL,
	[prefix] [nvarchar](5) NOT NULL,
 CONSTRAINT [PK__orders__3213E83F8699FE92] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permissions]    Script Date: 12/9/2023 9:55:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permissions](
	[id] [bigint] IDENTITY(0,1) NOT NULL,
	[allow_access] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 12/9/2023 9:55:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[category_id] [bigint] NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[price] [float] NOT NULL,
	[is_active] [bit] NOT NULL,
	[amount] [int] NOT NULL,
	[expiration_date] [date] NOT NULL,
	[created_at] [date] NOT NULL,
	[updated_at] [date] NOT NULL,
	[prefix] [nvarchar](5) NOT NULL,
	[note] [nvarchar](4000) NULL,
	[supplier] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[promotions]    Script Date: 12/9/2023 9:55:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[promotions](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[is_active] [bit] NOT NULL,
	[created_at] [date] NOT NULL,
	[code] [nvarchar](6) NOT NULL,
	[prefix] [nvarchar](5) NOT NULL,
	[ratio] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[receipts]    Script Date: 12/9/2023 9:55:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[receipts](
	[id] [bigint] NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[receieved] [float] NOT NULL,
	[expense] [float] NOT NULL,
	[created_at] [date] NOT NULL,
	[prefix] [nvarchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[role_permission]    Script Date: 12/9/2023 9:55:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[role_permission](
	[permission_id] [bigint] NOT NULL,
	[role_id] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[permission_id] ASC,
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 12/9/2023 9:55:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[id] [bigint] NOT NULL,
	[name] [varchar](30) NOT NULL,
 CONSTRAINT [PK__roles__3213E83FBCD8B838] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[suppliers]    Script Date: 12/9/2023 9:55:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[suppliers](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[phone_number] [varchar](10) NOT NULL,
	[address] [nvarchar](255) NOT NULL,
	[created_at] [date] NULL,
	[updated_at] [date] NULL,
	[show] [bit] NOT NULL,
	[prefix] [nvarchar](5) NOT NULL,
	[Note] [nvarchar](4000) NULL,
 CONSTRAINT [PK__supplier__3213E83FE8F7E6EA] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 12/9/2023 9:55:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[role_id] [bigint] NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[created_at] [date] NOT NULL,
	[updated_at] [date] NOT NULL,
	[password] [nchar](20) NULL,
	[permission] [nvarchar](50) NULL,
	[expirationTime] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[categories] ON 

INSERT [dbo].[categories] ([id], [name], [prefix]) VALUES (2, N'Banh mi', N'TL')
INSERT [dbo].[categories] ([id], [name], [prefix]) VALUES (3, N'Banh ngot', N'TL')
INSERT [dbo].[categories] ([id], [name], [prefix]) VALUES (4, N'Banh kem nho', N'TL')
INSERT [dbo].[categories] ([id], [name], [prefix]) VALUES (5, N'Banh kem', N'TL')
INSERT [dbo].[categories] ([id], [name], [prefix]) VALUES (6, N'Dong goi', N'TL')
INSERT [dbo].[categories] ([id], [name], [prefix]) VALUES (7, N'Bánh mi', N'BM')
INSERT [dbo].[categories] ([id], [name], [prefix]) VALUES (8, N'Bánh bao', N'BB')
INSERT [dbo].[categories] ([id], [name], [prefix]) VALUES (9, N'Bánh trung thu', N'BTT')
INSERT [dbo].[categories] ([id], [name], [prefix]) VALUES (10, N'Bánh kem', N'BK')
INSERT [dbo].[categories] ([id], [name], [prefix]) VALUES (11, N'Bánh pizza', N'BP')
INSERT [dbo].[categories] ([id], [name], [prefix]) VALUES (12, N'Bánh bông lan', N'BBL')
INSERT [dbo].[categories] ([id], [name], [prefix]) VALUES (13, N'Noel', N'TL')
SET IDENTITY_INSERT [dbo].[categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Chi] ON 

INSERT [dbo].[Chi] ([id], [name], [quantity], [price]) VALUES (1, N'Ghế', 2, CAST(50000.00 AS Decimal(10, 2)))
INSERT [dbo].[Chi] ([id], [name], [quantity], [price]) VALUES (3, N'ly', 1234, CAST(222222.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Chi] OFF
GO
INSERT [dbo].[import_product] ([import_id], [product_id], [price], [amount]) VALUES (1, 1, 20000, 10)
GO
SET IDENTITY_INSERT [dbo].[imports] ON 

INSERT [dbo].[imports] ([id], [supplier_id], [admin_id], [total], [created_at], [is_inter], [prefix]) VALUES (1, 1, 1, 10, CAST(N'2023-11-14' AS Date), 1, N'IPP')
SET IDENTITY_INSERT [dbo].[imports] OFF
GO
INSERT [dbo].[order_detail] ([order_id], [product_id], [price], [total]) VALUES (N'1         ', N'3         ', 20000, 5)
INSERT [dbo].[order_detail] ([order_id], [product_id], [price], [total]) VALUES (N'1         ', N'1         ', 20000, 3)
INSERT [dbo].[order_detail] ([order_id], [product_id], [price], [total]) VALUES (N'2         ', N'1         ', 20000, 5)
INSERT [dbo].[order_detail] ([order_id], [product_id], [price], [total]) VALUES (N'18        ', N'12        ', 30000, 1)
INSERT [dbo].[order_detail] ([order_id], [product_id], [price], [total]) VALUES (N'19        ', N'8         ', 20000, 1)
INSERT [dbo].[order_detail] ([order_id], [product_id], [price], [total]) VALUES (N'20        ', N'1         ', 20000, 2)
INSERT [dbo].[order_detail] ([order_id], [product_id], [price], [total]) VALUES (N'17        ', N'12        ', 30000, 1)
INSERT [dbo].[order_detail] ([order_id], [product_id], [price], [total]) VALUES (N'23        ', N'13        ', 15000, 2)
INSERT [dbo].[order_detail] ([order_id], [product_id], [price], [total]) VALUES (N'25        ', N'14        ', 50000, 2)
GO
SET IDENTITY_INSERT [dbo].[orders] ON 

INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (1, 20, 1, 1, 20000, N'olaoal', N'q7', 1, 1, 1, 0, 1, 1, 0, CAST(N'2023-11-18' AS Date), N'no', 1, 20000, N'HD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (2, 20, 1, 1, 20000, N'sushi', N'q10', 0, 1, 1, 0, 1, 1, 0, CAST(N'2023-11-18' AS Date), N'no', 1, 20000, N'HD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (5, 20, 1, 1, 150000, N'Khong', N'Khong', 1, 1, 6, 1, 1, 1, 0, CAST(N'2023-11-27' AS Date), N'', 1, 150000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (6, 20, 1, 1, 150000, N'Khong', N'Khong', 1, 1, 6, 1, 1, 1, 0, CAST(N'2023-11-27' AS Date), N'', 1, 150000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (7, 20, 1, 1, 150000, N'Khong', N'Khong', 1, 1, 6, 1, 1, 1, 0, CAST(N'2023-11-27' AS Date), N'', 1, 150000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (8, 20, 1, 1, 150000, N'Khong', N'Khong', 1, 1, 6, 1, 1, 1, 0, CAST(N'2023-11-27' AS Date), N'', 1, 150000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (10, 20, 1, 1, 225000, N'minh', N'Khong', 1, 1, 9, 1, 1, 1, 0, CAST(N'2023-11-27' AS Date), N'', 1, 225000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (11, 20, 1, 1, 50000, N'Khong', N'Khong', 1, 1, 2, 1, 1, 1, 0, CAST(N'2023-11-28' AS Date), N'', 1, 50000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (13, 20, 1, 1, 90000, N'duy', N'Khong', 1, 1, 9, 1, 1, 1, 0, CAST(N'2023-12-02' AS Date), N'', 1, 90000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (14, 20, 1, 1, 75000, N'Khong', N'Khong', 1, 1, 5, 1, 1, 1, 0, CAST(N'2023-12-02' AS Date), N'', 1, 75000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (17, 20, 1, 1, 15000, N'2', N'Khong', 1, 1, 1, 1, 1, 1, 0, CAST(N'2023-12-02' AS Date), N'', 1, 15000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (18, 20, 1, 1, 15000, N'Khong', N'Khong', 1, 1, 1, 1, 1, 1, 0, CAST(N'2023-12-02' AS Date), N'', 1, 15000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (19, 22, 1, 1, 20000, N'Khong', N'Khong', 0, 2, 1, 1, 1, 1, 0, CAST(N'2023-12-02' AS Date), N'', 1, 20000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (20, 23, 1, 1, 80000, N'ABC Quận 7', N'Khong', 1, 3, 2, 1, 1, 1, 0, CAST(N'2023-12-02' AS Date), N'', 1, 80000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (23, 20, 1, 1, 30000, N'phat_test', N'q7', 1, 1, 2, 0, 1, 1, 0, CAST(N'2023-12-08' AS Date), N'no', 1, 30000, N'OD')
INSERT [dbo].[orders] ([id], [promotion_id], [receipt_id], [cashier_id], [price], [name], [address], [status], [type], [total], [ship_fee], [payment_method], [is_paid], [prepay], [ordered_at], [note], [change], [receieved], [prefix]) VALUES (25, 20, 1, 1, 100000, N'phat_test2', N'q3', 1, 1, 2, 0, 1, 1, 0, CAST(N'2023-12-08' AS Date), N'no', 1, 100000, N'OD')
SET IDENTITY_INSERT [dbo].[orders] OFF
GO
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([id], [category_id], [name], [price], [is_active], [amount], [expiration_date], [created_at], [updated_at], [prefix], [note], [supplier]) VALUES (1, 4, N'banh kem cheese', 50000, 1, 15, CAST(N'2023-11-14' AS Date), CAST(N'2023-10-29' AS Date), CAST(N'2023-10-29' AS Date), N'SP', N'haha', NULL)
INSERT [dbo].[products] ([id], [category_id], [name], [price], [is_active], [amount], [expiration_date], [created_at], [updated_at], [prefix], [note], [supplier]) VALUES (3, 3, N'banh donut', 20000, 1, 2, CAST(N'2023-11-18' AS Date), CAST(N'2023-11-18' AS Date), CAST(N'2023-11-18' AS Date), N'SP', N'no', NULL)
INSERT [dbo].[products] ([id], [category_id], [name], [price], [is_active], [amount], [expiration_date], [created_at], [updated_at], [prefix], [note], [supplier]) VALUES (8, 12, N'Bánh bông lan trứng muối', 20000, 1, 6, CAST(N'2023-11-28' AS Date), CAST(N'2023-11-28' AS Date), CAST(N'2023-10-29' AS Date), N'SP', N'Bánh rất ngon', NULL)
INSERT [dbo].[products] ([id], [category_id], [name], [price], [is_active], [amount], [expiration_date], [created_at], [updated_at], [prefix], [note], [supplier]) VALUES (10, 2, N'bánh mì bơ tỏi', 25000, 1, 2, CAST(N'2023-11-28' AS Date), CAST(N'2023-11-28' AS Date), CAST(N'2023-10-29' AS Date), N'SP', NULL, NULL)
INSERT [dbo].[products] ([id], [category_id], [name], [price], [is_active], [amount], [expiration_date], [created_at], [updated_at], [prefix], [note], [supplier]) VALUES (12, 5, N'bánh kem xoài', 30000, 1, 26, CAST(N'2023-11-28' AS Date), CAST(N'2023-11-28' AS Date), CAST(N'2023-10-29' AS Date), N'SP', NULL, N'Xưởng quận 2')
INSERT [dbo].[products] ([id], [category_id], [name], [price], [is_active], [amount], [expiration_date], [created_at], [updated_at], [prefix], [note], [supplier]) VALUES (13, 9, N'Banh trung thu nhan thap cam', 15000, 1, 5, CAST(N'2023-12-31' AS Date), CAST(N'2023-12-08' AS Date), CAST(N'2023-12-08' AS Date), N'SP', NULL, NULL)
INSERT [dbo].[products] ([id], [category_id], [name], [price], [is_active], [amount], [expiration_date], [created_at], [updated_at], [prefix], [note], [supplier]) VALUES (14, 13, N'Banh kem xmas', 50000, 1, 5, CAST(N'2023-12-31' AS Date), CAST(N'2023-12-08' AS Date), CAST(N'2023-12-08' AS Date), N'SP', NULL, NULL)
SET IDENTITY_INSERT [dbo].[products] OFF
GO
SET IDENTITY_INSERT [dbo].[promotions] ON 

INSERT [dbo].[promotions] ([id], [name], [is_active], [created_at], [code], [prefix], [ratio]) VALUES (20, N'Giangsinh', 1, CAST(N'2023-11-14' AS Date), N'001', N'KM', 50)
INSERT [dbo].[promotions] ([id], [name], [is_active], [created_at], [code], [prefix], [ratio]) VALUES (22, N'Khong Giam', 1, CAST(N'2023-12-02' AS Date), N'000', N'KM', 0)
INSERT [dbo].[promotions] ([id], [name], [is_active], [created_at], [code], [prefix], [ratio]) VALUES (23, N'Sinh nhat ABC', 1, CAST(N'2023-12-02' AS Date), N'002', N'KM', 20)
SET IDENTITY_INSERT [dbo].[promotions] OFF
GO
INSERT [dbo].[receipts] ([id], [name], [receieved], [expense], [created_at], [prefix]) VALUES (1, N'Ban hang', 10000, 20000, CAST(N'2023-11-14' AS Date), N'BN')
GO
INSERT [dbo].[roles] ([id], [name]) VALUES (1, N'1')
INSERT [dbo].[roles] ([id], [name]) VALUES (2, N'Giam doc')
INSERT [dbo].[roles] ([id], [name]) VALUES (3, N'Nhan vien ke toan')
GO
SET IDENTITY_INSERT [dbo].[suppliers] ON 

INSERT [dbo].[suppliers] ([id], [name], [phone_number], [address], [created_at], [updated_at], [show], [prefix], [Note]) VALUES (1, N'Duy', N'0987654321', N'Q7', CAST(N'2023-11-14' AS Date), CAST(N'2023-11-14' AS Date), 1, N'KH', NULL)
INSERT [dbo].[suppliers] ([id], [name], [phone_number], [address], [created_at], [updated_at], [show], [prefix], [Note]) VALUES (2, N'Xưởng quận 6', N'012345677', N'quận 6', CAST(N'2023-11-27' AS Date), CAST(N'2023-11-27' AS Date), 1, N'SP', NULL)
INSERT [dbo].[suppliers] ([id], [name], [phone_number], [address], [created_at], [updated_at], [show], [prefix], [Note]) VALUES (3, N'Xưởng quận 2', N'023785389', N'quận 2', CAST(N'2023-11-27' AS Date), CAST(N'2023-11-27' AS Date), 1, N'SP', NULL)
INSERT [dbo].[suppliers] ([id], [name], [phone_number], [address], [created_at], [updated_at], [show], [prefix], [Note]) VALUES (4, N'Xưởng quận 3', N'838479287', N'quận 3', CAST(N'2023-11-27' AS Date), CAST(N'2023-11-27' AS Date), 1, N'SP', NULL)
INSERT [dbo].[suppliers] ([id], [name], [phone_number], [address], [created_at], [updated_at], [show], [prefix], [Note]) VALUES (5, N'Xưởng quận 7', N'924829034', N'quận 7', CAST(N'2023-11-27' AS Date), CAST(N'2023-11-27' AS Date), 1, N'SP', NULL)
SET IDENTITY_INSERT [dbo].[suppliers] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([id], [role_id], [name], [created_at], [updated_at], [password], [permission], [expirationTime]) VALUES (1, 1, N'Minh', CAST(N'2023-11-14' AS Date), CAST(N'2023-11-14' AS Date), NULL, NULL, NULL)
INSERT [dbo].[users] ([id], [role_id], [name], [created_at], [updated_at], [password], [permission], [expirationTime]) VALUES (5, 3, N'nhanvien1', CAST(N'2023-11-27' AS Date), CAST(N'2023-11-27' AS Date), N'nhanvien1           ', N'Thêm, xóa', CAST(N'2023-11-27T23:55:39.000' AS DateTime))
INSERT [dbo].[users] ([id], [role_id], [name], [created_at], [updated_at], [password], [permission], [expirationTime]) VALUES (6, 2, N'giamdoc', CAST(N'2023-11-27' AS Date), CAST(N'2023-11-27' AS Date), N'giamdoc             ', NULL, NULL)
SET IDENTITY_INSERT [dbo].[users] OFF
GO
ALTER TABLE [dbo].[categories] ADD  DEFAULT ('TL') FOR [prefix]
GO
ALTER TABLE [dbo].[imports] ADD  DEFAULT ('D') FOR [prefix]
GO
ALTER TABLE [dbo].[orders] ADD  CONSTRAINT [DF__orders__prefix__4F7CD00D]  DEFAULT ('HD') FOR [prefix]
GO
ALTER TABLE [dbo].[products] ADD  DEFAULT ('SP') FOR [prefix]
GO
ALTER TABLE [dbo].[promotions] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[promotions] ADD  DEFAULT ('KM') FOR [prefix]
GO
ALTER TABLE [dbo].[receipts] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[receipts] ADD  DEFAULT ('BN') FOR [prefix]
GO
ALTER TABLE [dbo].[suppliers] ADD  CONSTRAINT [DF__suppliers__creat__440B1D61]  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[suppliers] ADD  CONSTRAINT [DF__suppliers__updat__44FF419A]  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[suppliers] ADD  CONSTRAINT [DF_suppliers_show/hide]  DEFAULT ((1)) FOR [show]
GO
ALTER TABLE [dbo].[suppliers] ADD  CONSTRAINT [DF__suppliers__prefi__45F365D3]  DEFAULT ('KH') FOR [prefix]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[images]  WITH CHECK ADD  CONSTRAINT [FK_2] FOREIGN KEY([product_id])
REFERENCES [dbo].[products] ([id])
GO
ALTER TABLE [dbo].[images] CHECK CONSTRAINT [FK_2]
GO
ALTER TABLE [dbo].[import_product]  WITH CHECK ADD  CONSTRAINT [FK_8] FOREIGN KEY([import_id])
REFERENCES [dbo].[imports] ([id])
GO
ALTER TABLE [dbo].[import_product] CHECK CONSTRAINT [FK_8]
GO
ALTER TABLE [dbo].[import_product]  WITH CHECK ADD  CONSTRAINT [FK_9] FOREIGN KEY([product_id])
REFERENCES [dbo].[products] ([id])
GO
ALTER TABLE [dbo].[import_product] CHECK CONSTRAINT [FK_9]
GO
ALTER TABLE [dbo].[imports]  WITH CHECK ADD  CONSTRAINT [FK_5] FOREIGN KEY([supplier_id])
REFERENCES [dbo].[suppliers] ([id])
GO
ALTER TABLE [dbo].[imports] CHECK CONSTRAINT [FK_5]
GO
ALTER TABLE [dbo].[imports]  WITH CHECK ADD  CONSTRAINT [FK_6] FOREIGN KEY([admin_id])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[imports] CHECK CONSTRAINT [FK_6]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_11] FOREIGN KEY([receipt_id])
REFERENCES [dbo].[receipts] ([id])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_11]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_12] FOREIGN KEY([cashier_id])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_12]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_promotions] FOREIGN KEY([promotion_id])
REFERENCES [dbo].[promotions] ([id])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_promotions]
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [FK_1] FOREIGN KEY([category_id])
REFERENCES [dbo].[categories] ([id])
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK_1]
GO
ALTER TABLE [dbo].[role_permission]  WITH CHECK ADD  CONSTRAINT [FK_3] FOREIGN KEY([permission_id])
REFERENCES [dbo].[permissions] ([id])
GO
ALTER TABLE [dbo].[role_permission] CHECK CONSTRAINT [FK_3]
GO
ALTER TABLE [dbo].[role_permission]  WITH CHECK ADD  CONSTRAINT [FK_4] FOREIGN KEY([role_id])
REFERENCES [dbo].[roles] ([id])
GO
ALTER TABLE [dbo].[role_permission] CHECK CONSTRAINT [FK_4]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_7] FOREIGN KEY([role_id])
REFERENCES [dbo].[roles] ([id])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_7]
GO
ALTER TABLE [dbo].[promotions]  WITH CHECK ADD  CONSTRAINT [CK_1] CHECK  (([ratio]>=(0) AND [ratio]<=(101)))
GO
ALTER TABLE [dbo].[promotions] CHECK CONSTRAINT [CK_1]
GO
/****** Object:  StoredProcedure [dbo].[chiTietBanBanhNoelThuTienMat]    Script Date: 12/9/2023 9:55:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[chiTietBanBanhNoelThuTienMat]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        o.ordered_at,
        od.product_id,
        p.name,
        SUM(od.total) AS Amount,
        MAX(od.price) AS Price,
        SUM(od.total * od.price) AS Total
    FROM
        order_detail od
    JOIN
        products p ON od.product_id = p.id
    JOIN
        orders o ON od.order_id = o.id
    WHERE
        p.category_id = '13'
    GROUP BY
        o.ordered_at, od.product_id, p.name;
END
GO
/****** Object:  StoredProcedure [dbo].[chiTietBanBanhThuTienMat]    Script Date: 12/9/2023 9:55:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[chiTietBanBanhThuTienMat]
AS
SELECT
    o.ordered_at,
    od.product_id,
    p.name,
    SUM(od.total) AS Amount,
    MAX(od.price) AS Price,
    SUM(od.total * od.price) AS Total
FROM
    order_detail od
JOIN
    products p ON od.product_id = p.id
JOIN
    orders o ON od.order_id = o.id
GROUP BY
    o.ordered_at, od.product_id, p.name;
GO
/****** Object:  StoredProcedure [dbo].[chiTietBanBanhTrungThuThuTienMat]    Script Date: 12/9/2023 9:55:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[chiTietBanBanhTrungThuThuTienMat]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        o.ordered_at,
        od.product_id,
        p.name,
        SUM(od.total) AS Amount,
        MAX(od.price) AS Price,
        SUM(od.total * od.price) AS Total
    FROM
        order_detail od
    JOIN
        products p ON od.product_id = p.id
    JOIN
        orders o ON od.order_id = o.id
    WHERE
        p.category_id = '9'
    GROUP BY
        o.ordered_at, od.product_id, p.name;
END
GO
/****** Object:  StoredProcedure [dbo].[ImportInToNhapBanhNoiBo]    Script Date: 12/9/2023 9:55:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ImportInToNhapBanhNoiBo]
AS
BEGIN
    SELECT id AS MaBanh, name AS TenBanh, amount AS Ton, amount AS SoLuong, price AS Gia 
    FROM products;
END;
GO
/****** Object:  StoredProcedure [dbo].[SelectDanhMucKhachHang]    Script Date: 12/9/2023 9:55:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectDanhMucKhachHang]
AS
BEGIN
    SELECT * FROM [ABC_bakery].[dbo].[suppliers]
END
GO
