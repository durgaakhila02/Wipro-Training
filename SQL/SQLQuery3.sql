USE OrderManagementDB;
GO

IF OBJECT_ID('Customers', 'U') IS NULL
CREATE TABLE Customers (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Phone NVARCHAR(20),
    CreatedDate DATETIME DEFAULT GETDATE()
);

IF OBJECT_ID('Products', 'U') IS NULL
CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName NVARCHAR(100) NOT NULL,
    SKU NVARCHAR(50) NOT NULL UNIQUE,
    Price DECIMAL(10,2) NOT NULL CHECK (Price >= 0),
    StockQuantity INT NOT NULL CHECK (StockQuantity >= 0),
    CreatedDate DATETIME DEFAULT GETDATE()
);

IF OBJECT_ID('Orders', 'U') IS NULL
CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT NOT NULL,
    OrderDate DATETIME DEFAULT GETDATE(),
    OrderStatus NVARCHAR(20) DEFAULT 'Pending',
    CONSTRAINT FK_Orders_Customers 
        FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

IF OBJECT_ID('OrderItems', 'U') IS NULL
CREATE TABLE OrderItems (
    OrderItemID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT NOT NULL,
    ProductID INT NOT NULL,
    Quantity INT NOT NULL CHECK (Quantity > 0),
    UnitPrice DECIMAL(10,2) NOT NULL CHECK (UnitPrice >= 0),
    CONSTRAINT FK_OrderItems_Orders 
        FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    CONSTRAINT FK_OrderItems_Products 
        FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    CONSTRAINT UQ_Order_Product UNIQUE (OrderID, ProductID)
);

GO

IF OBJECT_ID('vw_OrderTotals', 'V') IS NOT NULL
    DROP VIEW vw_OrderTotals;
GO

CREATE VIEW vw_OrderTotals AS
SELECT 
    o.OrderID,
    SUM(oi.Quantity * oi.UnitPrice) AS OrderTotal
FROM Orders o
JOIN OrderItems oi ON o.OrderID = oi.OrderID
GROUP BY o.OrderID;
GO
