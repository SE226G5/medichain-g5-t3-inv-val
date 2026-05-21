# API Specifications

## 1. Overview

The INV-VAL module provides inventory validation and material availability checking for laboratory tests.
The module ensures that laboratory tests cannot be performed using unavailable or expired chemical materials.

---

## 2. Main Endpoints

### Endpoint 1: Check Material Availability

- Method: GET
- What it does:
Checks whether the required material is available in stock.

- Required Data:
  - MaterialID
  - RequiredQuantity

- Returned Data:
  - Availability Status
  - Current Quantity

---

### Endpoint 2: Validate Material Expiration

- Method: GET

- What it does:
Checks whether the chemical material batch is expired.

- Required Data:
  - BatchID

- Returned Data:
  - Expiration Status
  - Expiry Date

---

### Endpoint 3: Consume Material Quantity

- Method: POST

- What it does:
Deducts consumed material quantities after performing a laboratory test.

- Required Data:
  - BatchID
  - ConsumedQuantity
  - TestID

- Returned Data:
  - Updated Quantity
  - Operation Status

---

### Endpoint 4: Generate Inventory Alert

- Method: POST

- What it does:
Creates alerts for expired materials or low stock quantities.

- Required Data:
  - MaterialID
  - AlertType

- Returned Data:
  - Alert Message
  - Alert Status
