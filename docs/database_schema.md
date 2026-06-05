# Database Schema

## 1. Entity-Relationship Diagram (ERD)

![ERD Diagram](../photo_2026-05-12_19-06-20.jpg)

Main Relationships:
- One Material has many Batches
- One Lab Test requires many Materials
- One User can perform many Test Executions
- One Test Execution consumes materials from batches

---

## 2. Tables List

| Table Name | Purpose / Description |
| :--- | :--- |
| `Users` | Stores user accounts and system roles |
| `Roles` | Stores system roles such as Lab Analyst and Lab Manager |
| `Materials` | Stores chemical material information |
| `Batches` | Stores material batches with quantity and expiry date |
| `LabTests` | Stores laboratory test information |
| `TestRequiredMaterials` | Stores required materials for each lab test |
| `TestExecutions` | Stores executed laboratory tests |
| `MaterialConsumption` | Stores consumed quantities from batches |
| `Alerts` | Stores low stock and expiry alerts |

---

## 3. Shared Data (Integration Points)

### Shared Table/ID: `MaterialID`
- Shared With: Inventory / ERP Module
- Purpose: Synchronize chemical material information and stock quantities

### Shared Table/ID: `UserID`
- Shared With: Authentication & Employee Management Module
- Purpose: Verify user identity and permissions

### Shared Table/ID: `TestID`
- Shared With: Laboratory Tracking Module
- Purpose: Track laboratory test execution status

### Shared Table/ID: `BatchID`
- Shared With: Warehouse / Inventory Module
- Purpose: Track material batches and expiration dates

### Shared Table/ID: `ExecutionID`
- Shared With: Reporting & Analytics Module
- Purpose: Generate reports about material usage and test execution
