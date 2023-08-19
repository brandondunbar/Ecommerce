/*
* AffiliateModel.cs
* 
* Module Description:
*     This module defines the data structure and relationships for the Affiliate entity within the E-Commerce application.
* 
* Class Definitions:
*     - AffiliateModel: Represents an affiliate entity with details such as name, email, commission rate, and more.
*       - Properties:
*         - affiliate_id: The primary key identifier for the affiliate.
*         - user_id: Foreign key linking to the associated user in the Users table.
*         - name: The name or label of the affiliate.
*         - email: Contact email for the affiliate.
*         - website: The website or platform where the affiliate promotes products.
*         - referral_code: Unique referral code or identifier used by the affiliate.
*         - commission_rate: Percentage rate for the affiliate's commission.
*         - status: Status of the affiliate, represented as an enumeration (e.g., 'Active', 'Suspended', 'Pending Approval').
*         - signup_date: Date and time of the affiliate's registration to the program.
*         - last_payment_date: Date and time of the last commission payment made to the affiliate.
*         - payment_details: Preferred payment method or details for the affiliate (stored securely).
*         - payment_threshold: Minimum amount required in earnings before a payment is issued.
*         - current_balance: Current outstanding commission balance for the affiliate.
*         - total_earned: Cumulative commission earned by the affiliate.
*         - notes: Any additional notes or details about the affiliate.
* 
*       - Relationships:
*         - User: Navigation property to retrieve details of the user associated with the affiliate.
* 
*     - AffiliateStatus: An enumeration representing possible statuses for an affiliate.
*
* Dependencies:
*     - Entity Framework: Used for entity mapping, database interaction, and managing relationships between tables.
*
* Maintained by: Brandon Dunbar
* Last Updated: 8/17/23
*/


IMPORT necessary libraries

NAMESPACE ECommerceApp.Data.Entities
{
    DEFINE class AffiliateModel
    {
        DECLARE property int affiliate_id, marked as PrimaryKey
        DECLARE property int user_id, marked as ForeignKey linking to Users table

        // Properties for the affiliate's details
        DECLARE property string name
        DECLARE property string email
        DECLARE property string website
        DECLARE property string referral_code
        DECLARE property decimal commission_rate with precision 5, scale 2
        DECLARE property Enum AffiliateStatus status
        DECLARE property DateTime signup_date
        DECLARE property DateTime? last_payment_date  // Nullable since there may not be a payment yet
        DECLARE property string payment_details
        DECLARE property decimal payment_threshold with precision 10, scale 2
        DECLARE property decimal current_balance with precision 10, scale 2
        DECLARE property decimal total_earned with precision 10, scale 2
        DECLARE property string notes

        // Relationships
        DECLARE NavigationProperty User user  // Link to the user associated with the affiliate
    }

    DEFINE Enum AffiliateStatus
    {
        VALUES Active, Suspended, PendingApproval
    }
}
