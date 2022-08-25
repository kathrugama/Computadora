USE [Computadora]
GO

/****** Object:  Table [dbo].[Detalles_Computadora]    Script Date: 25/8/2022 02:08:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Detalles_Computadora](
	[Codigo] [varchar](10) NOT NULL,
	[Tipo_de_Computadora] [varchar](50) NULL,
	[Procesador] [nvarchar](50) NULL,
	[Memoria_RAM] [nvarchar](50) NULL,
	[Tipo_de_disco_duro] [nvarchar](50) NULL,
	[Almacenamiento] [nvarchar](50) NULL,
 CONSTRAINT [PK_Detalles_Computadora] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


