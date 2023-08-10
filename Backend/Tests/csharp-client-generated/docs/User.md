# IO.Swagger.Model.User
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **long?** | Unique identifier for the user. | 
**Username** | **string** | Unique username used for login. | 
**Email** | **string** | Email address of the user. | 
**FirstName** | **string** | First name of the user. | 
**LastName** | **string** | Last name of the user. | 
**DateRegistered** | **DateTime?** | Date and time when the user registered. | [optional] 
**LastLogin** | **DateTime?** | Date and time of the user&#x27;s last successful login. | [optional] 
**Role** | **string** | Role or roles assigned to the user. This could be an array if users can have multiple roles. | [optional] 
**IsActive** | **bool?** | Flag indicating if the user&#x27;s account is active. | [optional] [default to true]
**AvatarUrl** | **string** | URL to the user&#x27;s avatar or profile picture (if any). | [optional] 
**Address** | **string** | Physical address of the user (if provided). | [optional] 
**Phone** | **string** | Contact phone number for the user. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

