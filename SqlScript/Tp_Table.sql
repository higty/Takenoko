CREATE TABLE [User]
(UserCD UNIQUEIDENTIFIER NOT NULL
,DisplayName NVARCHAR(64) NOT NULL
,Twitter NVARCHAR(64) NOT NULL
,Facebook NVARCHAR(64) NOT NULL
,Instagram NVARCHAR(64) NOT NULL
,Youtube NVARCHAR(64) NOT NULL

,CONSTRAINT User_PrimaryKey PRIMARY KEY CLUSTERED (UserCD)
)
GO


SELECT * FROM [User]
GO










