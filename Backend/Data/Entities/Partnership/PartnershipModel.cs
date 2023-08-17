/*
* PartnershipModel.cs
* 
* Module Description:
*     This module defines the data structure and relationships for the Partnership entity within the E-Commerce application.
* 
* Class Definitions:
*     - PartnershipModel: Represents a partnership entity detailing agreements or collaborations with external partners.
*       - Properties:
*         - partnership_id: The primary key identifier for the partnership.
*         - partner_name: The name of the partner entity or organization.
*         - contact_person: The primary contact person for the partnership.
*         - contact_email: Contact email for inquiries related to the partnership.
*         - partnership_type: The type or nature of the partnership agreement.
*         - start_date: Date and time when the partnership agreement started.
*         - end_date: Optional date and time when the partnership agreement is set to end.
*         - terms: Terms and conditions associated with the partnership.
*         - benefits: Benefits provided by the partnership.
*         - is_active: Flag indicating whether the partnership is currently active.
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
    DEFINE class PartnershipModel
    {
        DECLARE property int partnership_id, marked as PrimaryKey

        // Properties for partnership details
        DECLARE property string partner_name
        DECLARE property string contact_person
        DECLARE property string contact_email
        DECLARE property string partnership_type
        DECLARE property DateTime start_date
        DECLARE property DateTime? end_date, OPTIONAL (can be null)
        DECLARE property string terms
        DECLARE property string benefits
        DECLARE property bool is_active
    }
}
