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
*         - contact_position: Job title or position of the contact person.
*         - contact_email: Contact email for inquiries related to the partnership.
*         - contact_phone: Contact phone number for the partnership.
*         - partnership_type: The type or nature of the partnership agreement.
*         - start_date: Date when the partnership agreement started.
*         - end_date: Optional date when the partnership agreement is set to end.
*         - terms: Terms and conditions associated with the partnership.
*         - benefits: Benefits provided by the partnership.
*         - agreement_document: Path or link to the digital partnership agreement document.
*         - is_active: Flag indicating whether the partnership is currently active.
*         - renewal_date: Date when the partnership is up for renewal.
*         - metrics: Metrics related to the partnership.
*         - created_at: Date and time when the partnership record was created.
*         - updated_at: Date and time of the last update to the partnership record.
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
        DECLARE property string partner_name
        DECLARE property string contact_person
        DECLARE property string contact_position, with max length of 100 characters
        DECLARE property string contact_email
        DECLARE property string contact_phone, with max length of 20 characters
        DECLARE property Enum PartnershipType partnership_type
        DECLARE property DateTime start_date
        DECLARE property DateTime? end_date, OPTIONAL (can be null)
        DECLARE property string terms
        DECLARE property string benefits
        DECLARE property string agreement_document
        DECLARE property bool is_active
        DECLARE property DateTime? renewal_date, OPTIONAL (can be null)
        DECLARE property Json metrics, OPTIONAL (can be null)
        DECLARE property DateTime created_at
        DECLARE property DateTime updated_at
    }

    DEFINE Enum PartnershipType
    {
        VALUES Collaboration, Integration, Sponsorship, etc.
    }
}
