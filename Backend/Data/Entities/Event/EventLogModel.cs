/*
* EventLogModel.cs
* 
* Module Description:
*     This module defines the data structure and relationships for the Event Log entity within the E-Commerce application.
* 
* Class Definitions:
*     - EventLogModel: Represents an event log entry capturing system and user activities, errors, and other significant events.
*       - Properties:
*         - event_log_id: The primary key identifier for the log entry.
*         - user_id: Foreign key linking to the associated user in the Users table. Nullable as some events may not be directly linked to a user.
*         - timestamp: Date and time marking when the event took place.
*         - event_type: The type or category of the event (e.g., 'Login', 'Purchase', 'Error', 'System Update').
*         - description: Detailed information or message associated with the event.
*         - ip_address: The IP address from which the event was triggered.
*         - user_agent: Details about the user's browser, OS, and device.
*         - severity: Indicates the significance or urgency of the event, represented as an enumeration (e.g., 'Info', 'Warning', 'Error', 'Critical').
* 
*       - Relationships:
*         - User: Navigation property to fetch details of the user associated with the event, if applicable.
* 
*     - EventSeverity: An enumeration representing the potential severity levels of an event.
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
    DEFINE class EventLogModel
    {
        DECLARE property int event_log_id, marked as PrimaryKey
        DECLARE property int? user_id, marked as ForeignKey linking to Users table. Nullable since not all events are user-related.

        // Properties for the event log details
        DECLARE property DateTime timestamp
        DECLARE property string event_type, with max length 100
        DECLARE property string description
        DECLARE property string ip_address, with max length 50
        DECLARE property string user_agent
        DECLARE property Enum EventSeverity severity

        // Relationships
        DECLARE NavigationProperty User user  // Link to the user associated with the event, if any
    }

    DEFINE Enum EventSeverity
    {
        VALUES Info, Warning, Error, Critical
    }
}
