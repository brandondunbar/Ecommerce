# Database design and philosophy

## Introduction
The database holds all user and product information, as well as clerical data (order history, activity, etc.) This project uses PostgreSQL.

## Setup
To set up the database locally,

## Schema
Here is a diagram of the database schema:

![](./images/db_diagram.png)

## Tables

### Users

**Purpose**: This table represents a user of the website, grouping their relevant data into one place.

**Columns**:

| Column Name       | Data Type           | Description                                |
| ----------------- | :-----------------: | ------------------------------------------ |
| `user_id`         | SERIAL              | Primary key for the user.                  |
| `username`        | VARCHAR(50)         | Unique username chosen by the user.        |
| `password_hash`   | VARCHAR(256)        | Hashed version of the user's password.     |
| `email`           | VARCHAR(100)        | User's email address.                      |
| `first_name`      | VARCHAR(50)         | User's first name.                         |
| `last_name`       | VARCHAR(50)         | User's last name.                          |
| `date_registered` | DATETIME            | Date and time the user registered.         |
| `date_of_birth`   | DATE                | User's date of birth.                      |
| `phone_number`    | VARCHAR(15)         | User's contact number.                     |
| `profile_image`   | VARCHAR(255)        | Path to the user's profile image           |
| `is_active`       | BOOLEAN             | If the user's account is active            |
| `role`            | ENUM                | Role of the user (customer, admin, vendor) |
| `last_login`      | DATETIME            | Date and time of the user's last login     |

### ShippingAdresses

**Purpose**: This table represents the shipping address of a user. A single user can have many addresses, so the relationship is one User to many ShippingAdresses.

**Columns**:

| Column Name       | Data Type           | Description                                |
| ----------------- | :-----------------: | ------------------------------------------ |
| `address_id`      | SERIAL              | Primary key for the user.                  |
| `user_id`         | FK INT              | Foreign key linking to the `Users` table.  |
| `recipient_name`  | VARCHAR(100)        | Name of the recipient at this address.     |
| `street`          | VARCHAR(255)        | Street address.                            |
| `city`            | VARCHAR(100)        | City.                                      |
| `state`           | VARCHAR(100)        | State or province.                         |
| `postal_code`     | VARCHAR(20)         | Postal or ZIP code.                        |
| `country`         | VARCHAR(100)        | Country.                                   |
| `phone_number`    | VARCHAR(15)         | Contact phone number for delivery queries. |
| `is_default`      | BOOLEAN             | If the address is the default address.     |
| `address_notes`   | TEXT                | Any additional delivery instructions.      |

### PaymentMethods

**Purpose**: This table represents a user's method of payment.

**Columns**:

| Column Name         | Data Type           | Description                                                  |
| ------------------- | :-----------------: | ------------------------------------------------------------ |
| `payment_method_id` | SERIAL              | Primary key for the payment method.                          |
| `user_id`           | FK INT              | Foreign key linking to the `Users` table.                      |
| `provider`          | ENUM                | Payment provider (e.g., 'Stripe', 'PayPal', 'Bank').         |
| `token`             | VARCHAR(255)        | Token or identifier returned by the payment gateway.         |
| `payment_type`      | ENUM                | Type of payment method ('Credit Card', 'Bank Account', etc.) |
| `last_four_digits`  | VARCHAR(4)          | Last four digits of the card/account for reference.          |
| `expiration_date`   | DATE (optional)     | Expiry date if applicable (e.g., for credit cards).          |
| `is_default`        | BOOLEAN             | If this is the default payment method for the user.          |
| `created_at`        | TIMESTAMP           | Date and time when the payment method was added.             |
| `updated_at`        | TIMESTAMP           | Date and time of the last update to the payment method.      |

### Orders

**Purpose**: This table represents an order.

**Columns**:

| Column Name           | Data Type           | Description                                                                |
| --------------------- | :-----------------: | -------------------------------------------------------------------------- |
| `order_id`            | SERIAL              | Primary key for the order.                                                 |
| `user_id`             | FK INT              | Foreign key linking to the `Users` table.                                    |
| `shipping_address_id` | FK INT              | Foreign key linking to the `ShippingAddresses` table.                        |
| `order_date`          | TIMESTAMP           | Date and time when the order was placed.                                   |
| `order_status`        | ENUM                | Status of the order (e.g., 'Pending', 'Shipped', 'Delivered', 'Canceled'). |
| `total_price`         | DECIMAL(10, 2)      | Total price of the order, including any taxes or discounts.                |
| `shipping_cost`       | DECIMAL(7, 2)       | Cost of shipping for the order.                                            |
| `payment_method`      | VARCHAR(50)         | Method used for payment (e.g., 'Credit Card', 'PayPal', etc. ).            |
| `payment_status`      | ENUM                | Status of the payment (e.g., 'Paid', 'Pending', 'Refunded').               |
| `tracking_number`     | VARCHAR(100)        | Shipping tracking number, if available.                                    |
| `expected_delivery`   | DATE                | Expected delivery date, if provided by the shipper.                        |
| `notes`               | TEXT                | Any additional notes or instructions related to the order.                 |

### ShoppingCart

**Purpose**: This table represents a user's shopping cart.

**Columns**:

| Column Name           | Data Type           | Description                                                                |
| --------------------- | :-----------------: | -------------------------------------------------------------------------- |
| `cart_id`             | SERIAL              | Primary key for the shopping cart.                                         |
| `user_id`             | FK INT              | Foreign key linking to the `Users` table.                                  |
| `created_at`          | TIMESTAMP           | Date and time when the cart was created.                                   |
| `updated_at`          | TIMESTAMP           | Date and time of the last update to the cart.                              |

### CartItems

**Purpose**: This table represents a user's shopping cart.

**Columns**:

| Column Name           | Data Type           | Description                                                                |
| --------------------- | :-----------------: | -------------------------------------------------------------------------- |
| `cart_item_id`        | SERIAL              | Primary key for the cart item.                                             |
| `cart_id`             | FK INT              | Foreign key linking to the `ShoppingCart` table.                           |
| `product_id`          | FK INT              | Foreign key linking to the `Products` table.                               |
| `quantity`            | INT                 | Quantity of the product in the cart.                                       |
| `added_at`            | TIMESTAMP           | Date and time when the item was added to the cart.                         |

### Products

**Purpose**: This table represents an item for sale.

**Columns**:

| Column Name           | Data Type           | Description                                                                |
| --------------------- | :-----------------: | -------------------------------------------------------------------------- |
| `product_id`          | SERIAL              | Primary key for the item.                                                  |
| `category_id`         | FK INT              | Foreign key linking to the `Category` table.                               |
| `vendor_id`           | FK INT              | Foreign key linking to the `Vendor` table.                                 |
| `name`                | VARCHAR(255)        | Name of the product.                                                       |
| `description`         | TEXT                | Detailed description of the product.                                       |
| `price`               | DECIMAL(10, 2)      | Price of the product.                                                      |
| `stock_quantity`      | INT                 | Quantity of the product in stock.                                          |
| `is_available`        | BOOLEAN             | Flag to indicate if the product is available for purchase.                 |
| `image_url`           | VARCHAR(255)        | URL to the product's main image.                                           |
| `sku`                 | VARCHAR(100)        | Stock Keeping Unit (SKU) or unique code for the product.                   |
| `created_at`          | TIMESTAMP           | Date and time when the product was added.                                  |
| `updated_at`          | TIMESTAMP           | Date and time of the last update to the product.                           |
| `manufacturer`        | VARCHAR(255)        | Manufacturer or brand of the product.                                      |
| `weight`              | DECIMAL(7, 2)       | Weight of the product (for shipping calculations).                         |
| `dimensions`          | VARCHAR(50)         | Dimensions of the product (e.g., "10x20x30 cm").                           |
| `rating`              | DECIMAL(3, 2)       | Average rating of the product (if applicable).                             |

### Categories

**Purpose**: This table represents the categories items can be grouped by.

**Columns**:

| Column Name           | Data Type           | Description                                                                                  |
| --------------------- | :-----------------: | -------------------------------------------------------------------------------------------- |
| `category_id`         | SERIAL              | Primary key for the category.                                                                |
| `parent_id`           | FK INT              | Foreign key linking to the parent category for subcategories. Null for top-level categories. |
| `name`                | VARCHAR(255)        | Name of the category.                                                                        |
| `description`         | TEXT                | A brief description of what this category contains.                                          |
| `image_url`           | VARCHAR(255)        | URL to an image representing the category.                                                   |
| `display_order`       | INT                 | An integer for sorting categories on display.                                                |
| `created_at`          | TIMESTAMP           | Date and time when the category was created.                                                 |
| `updated_at`          | TIMESTAMP           | Date and time of the last update to the category.                                            |

### Reviews

**Purpose**: This table represents the categories items can be grouped by.

**Columns**:

| Column Name           | Data Type           | Description                                                                                  |
| --------------------- | :-----------------: | -------------------------------------------------------------------------------------------- |
| `review_id`           | SERIAL              | Primary key for the category.                                                                |
| `product_id`          | INT                 | Foreign key linking to the `Products` table.                                                 |
| `user_id`             | INT                 | Foreign key linking to the `Users` table. Indicates who wrote the review.                    |
| `rating`              | INT                 | Rating given by the user (e.g., 1 to 5).                                                     |
| `title`               | VARCHAR(255)        | Short title or summary of the review.                                                        |
| `content`             | TEXT                | Detailed review content.                                                                     |
| `is_approved`         | BOOLEAN             | A flag indicating if the review has been approved for display                                |
| `created_at`          | TIMESTAMP           | Date and time when the review was created.                                                   |
| `updated_at`          | TIMESTAMP           | Date and time of the last update to the review.                                              |

### InventoryLogs

**Purpose**: This table represents a log of all changes to the site's inventory.

**Columns**:

| Column Name           | Data Type           | Description                                                                                  |
| --------------------- | :-----------------: | -------------------------------------------------------------------------------------------- |
| `log_id`              | SERIAL              | Primary key for the log entry.                                                               |
| `product_id`          | FK INT              | Foreign key linking to the `Products` table.                                                 |
| `previous_quantity`   | INT                 | Quantity before the change. Zero if a new item is added.                                     |
| `new_quantity`        | INT                 | Quantity after the change.                                                                   |
| `change_reason`       | ENUM                | Reason for the change (e.g., 'Sale', 'Stock Replenishment', 'Adjustment').                   |
| `changed_by`          | VARCHAR             | ID or name of the user/system that made the change.                                          |
| `timestamp`           | TIMESTAMP           | Date and time of the change.                                                                 |

### Vendors

**Purpose**: This table represents a vendor who sells items on the site.

**Columns**:

| Column Name           | Data Type           | Description                                                                                  |
| --------------------- | :-----------------: | -------------------------------------------------------------------------------------------- |
| `vendor_id`           | SERIAL              | Primary key for the vendor.                                                                  |
| `user_id`             | FK INT              | Foreign key linking to the `Users` table.                                                    |
| `business_name`       | VARCHAR(255)        | The registered business name of the vendor.                                                  |
| `tax_id`              | VARCHAR(50)         | Tax identification number for the vendor.                                                    |
| `payment_info`        | TEXT                | Information or method for payments (details might be stored elsewhere for security).         |
| `shipping_policy`     | TEXT                | Vendor's shipping policy details.                                                            |
| `return_policy`       | TEXT                | Vendor's return policy details.                                                              |
| `is_verified`         | BOOLEAN             | Flag indicating if the vendor is verified/approved to sell.                                  |
| `created_at`          | TIMESTAMP           | Date and time when the vendor was added.                                                     |
| `updated_at`          | TIMESTAMP           | Date and time of the last update to the vendor details.                                      |

### Transactions

**Purpose**: This table represents financial transactions.

**Columns**:

| Column Name           | Data Type           | Description                                                                                   |
| --------------------- | :-----------------: | --------------------------------------------------------------------------------------------- |
| `transaction_id`      | SERIAL              | Primary key for the transaction.                                                              |
| `order_id`            | FK INT              | Foreign key linking to the Orders table. Provides context for the transaction.                |
| `user_id`             | FK INT              | Foreign key linking to the Users table. Helps identify which user the transaction relates to. |
| `amount`              | DECIMAL(10, 2)      | The amount of the transaction.                                                                |
| `currency`            | VARCHAR(5)          | Currency code for the transaction (e.g., USD, EUR).                                           |
| `transaction_type`    | VARCHAR(50)         | Type of transaction (e.g., 'Sale', 'Refund', 'Chargeback').                                   |
| `payment_method`      | VARCHAR(50)         | Method used for the transaction (e.g., 'Credit Card', 'PayPal', 'Bank Transfer').             |
| `payment_gateway`     | VARCHAR(50)         | The payment gateway or service used (e.g., 'Stripe', 'Square').                               |
| `transaction_status`  | VARCHAR(50)         | Status of the transaction (e.g., 'Completed', 'Pending', 'Failed').                           |
| `transaction_date`    | TIMESTAMP           | Date and time when the transaction took place.                                                |
| `fee`                 | DECIMAL(10, 2)      | Any fee associated with the transaction (e.g., processing fee).                               |
| `notes`               | TEXT                | Optional notes or additional information about the transaction.                               |

### Tags

**Purpose**: This table represents product tags used to filter and locate items.

**Columns**:

| Column Name           | Data Type           | Description                                                                                  |
| --------------------- | :-----------------: | -------------------------------------------------------------------------------------------- |
| `tag_id`              | SERIAL              | Primary key for the tag.                                                                     |
| `name`                | VARCHAR(255)        | The name or label of the tag (e.g., "Summer", "Exclusive").                                  |
| `description`         | TEXT                | A brief description or context about the tag (optional).                                     |
| `created_at`          | TIMESTAMP           | Date and time when the tag was created.                                                      |
| `updated_at`          | TIMESTAMP           | Date and time of the last update to the tag.                                                 |

### ProductTags

**Purpose**: This table represents product tags used to filter and locate items.

**Columns**:

| Column Name           | Data Type           | Description                                                                                  |
| --------------------- | :-----------------: | -------------------------------------------------------------------------------------------- |
| `product_tag_id`      | SERIAL              | Primary key for the product-tag association.                                                 |
| `product_id`          | FK INT              | Foreign key linking to the Products table.                                                   |
| `tag_id`              | INT                 | Foreign key linking to the Tags table.                                                       |
| `assigned_date`       | TIMESTAMP           | Date and time when the tag was assigned to the product.                                      |

### Subscriptions

**Purpose**: This table represents subscriptions.

**Columns**:

| Column Name           | Data Type           | Description                                                                                   |
| --------------------- | :-----------------: | --------------------------------------------------------------------------------------------- |
| `subscription_id`     | SERIAL              | Primary key for the subscription.                                                             |
| `user_id`             | FK INT              | Foreign key linking to the Users table. Indicates the user who has the subscription.          |
| `product_id`          | FK INT              | Foreign key linking to the Products table. If the subscription is tied to a specific product. |
| `start_date`          | DATE                | The start date of the subscription.                                                           |
| `end_date`            | DATE                | The end date of the subscription. It can be NULL for open-ended subscriptions.                |
| `billing_cycle`       | VARCHAR(50)         | How often the user is billed (e.g., 'Monthly', 'Annually').                                   |
| `status`              | VARCHAR(50)         | Current status of the subscription (e.g., 'Active', 'Paused', 'Canceled', 'Expired').         |
| `price`               | DECIMAL(10, 2)      | Price of the subscription for each billing cycle.                                             |
| `currency`            | VARCHAR(5)          | Currency code for the subscription price (e.g., USD, EUR).                                    |
| `last_billed`         | TIMESTAMP           | Date and time of the last billing event.                                                      |
| `next_billing`        | TIMESTAMP           | Date and time of the next scheduled billing event.                                            |
| `created_at`          | TIMESTAMP           | Date and time when the subscription was created.                                              |
| `updated_at`          | TIMESTAMP           | Date and time of the last update to the subscription.                                         |

### Returns

**Purpose**: This table represents product returns.

**Columns**:

| Column Name           | Data Type           | Description                                                                                         |
| --------------------- | :-----------------: | --------------------------------------------------------------------------------------------------- |
| `return_id`           | SERIAL              | Primary key for the return.                                                                         |
| `order_id`            | FK INT              | Foreign key linking to the Orders table. Provides context for the return based on a specific order. |
| `user_id`             | FK INT              | Foreign key linking to the Users table. Indicates the user initiating the return.                   |
| `product_id`          | FK INT              | Foreign key linking to the Products table. The specific product being returned.                     |
| `reason`              | TEXT                | Reason provided by the customer for the return.                                                     |
| `status`              | VARCHAR(50)         | Current status of the return (e.g., 'Pending', 'Accepted', 'Rejected', 'Refunded', 'Exchanged').    |
| `return_date`         | TIMESTAMP           | Date and time when the return was initiated.                                                        |
| `resolution_date`     | TIMESTAMP           | Date and time when the return was resolved (refunded, exchanged, etc.).                             |
| `notes`               | TEXT                | Any additional notes or details about the return.                                                   |

### Affiliates

**Purpose**: This table represents Affiliate users.

**Columns**:

| Column Name           | Data Type           | Description                                                                                         |
| --------------------- | :-----------------: | --------------------------------------------------------------------------------------------------- |
| `return_id`           | SERIAL              | Primary key for the affiliate.                                                                      |
| `user_id`             | FK INT              | Foreign key linking to the Users table. Indicates the user account associated with the affiliate.   |
| `name`                | VARCHAR(255)        | The name or label of the affiliate.                                                                 |
| `email`               | VARCHAR(255)        | Contact email for the affiliate.                                                                    |
| `website`             | VARCHAR(255)        | The website or platform where the affiliate promotes products.                                      |
| `commission_rate`     | DECIMAL(5, 2)       | Percentage rate for the affiliate's commission.                                                     |
| `status`              | VARCHAR(50)         | Status of the affiliate (e.g., 'Active', 'Suspended', 'Pending Approval').                          |
| `signup_date`         | TIMESTAMP           | Date and time when the affiliate joined the program.                                                |
| `last_payment_date`   | TIMESTAMP           | Date and time of the last commission payment to the affiliate.                                      |
| `total_earned`        | DECIMAL(10, 2)      | Total commission earned by the affiliate to date.                                                   |
| `notes`               | TEXT                | Any additional notes or details about the affiliate.                                                |

### EventLogs

**Purpose**: This table represents a log of site-wide events, such as a user signing up.

**Columns**:

| Column Name           | Data Type           | Description                                                                                         |
| --------------------- | :-----------------: | --------------------------------------------------------------------------------------------------- |
| `event_log_id`        | SERIAL              | Primary key for the log entry.                                                                      |
| `timestamp`           | TIMESTAMP           | Date and time when the event occurred.                                                              |
| `user_id`             | INT                 | Foreign key linking to the Users table. Identifies the user associated with the event (if any).     |
| `event_type`          | VARCHAR(100)        | Type or category of the event (e.g., 'Login', 'Purchase', 'Error', 'System Update').                |
| `description`         | TEXT                | Detailed description of the event or any messages associated with it.                               |
| `ip_address`          | VARCHAR(50)         | IP address from where the event was initiated. Useful for security audits.                          |
| `user_agent`          | TEXT                | Information about the user's browser, OS, and device.                                               |
| `severity`            | VARCHAR(50)         | Indicates the severity or importance of the event (e.g., 'Info', 'Warning', 'Error', 'Critical').   |

## Conventions
* Naming conventions:
    - Table names use PascalCase
    - Column names use snake_case

## Views, Stored Procedures, and Functions:
Database views used:

## Backup and Restore Procedures

To back up the database,
To restore the database from a backup,

## Performance Optimizations

## Change Log
