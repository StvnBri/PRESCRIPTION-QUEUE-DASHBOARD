# PRESCRIPTION-QUEUE-DASHBOARD

A centralized dashboard designed to monitor and manage prescription orders and their current queue status.

The system integrates data from MongoDB and SQL Server through ETL processes that extract, transform, and load prescription-related data into structured SQL tables. The dashboard provides a centralized view of prescription orders and their related information, helping users monitor and manage the prescription workflow efficiently.

## Key Features

* Prescription queue monitoring
* MongoDB to SQL Server data integration
* Full refresh ETL process for reference and related data
* Processing of nested MongoDB documents and arrays
* SQL Server-based data storage and reporting
* Prescription order and item tracking
* Integration with related patient, visit, medication, and reference data
* Automated logging of ETL processes

## Technologies Used

* VB.NET
* Windows Forms
* MongoDB
* Microsoft SQL Server
* SQL Server Stored Procedures
* SQL Views
* `SqlBulkCopy`

## ETL Architecture

The system processes data from MongoDB collections and transfers it into SQL Server tables. It supports both parent records and nested child data structures.

The general data flow is:

MongoDB → ETL Application → SQL Server Tables → SQL Views → Prescription Queue Dashboard
