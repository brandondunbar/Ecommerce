# IO.Swagger.Model.AffiliateCreate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Full name or company name of the affiliate. | 
**ContactEmail** | **string** | Contact email address for the affiliate. | 
**ReferralCode** | **string** | Unique code to be used by the affiliate for referrals. If not provided, the system could generate one. | [optional] 
**RegistrationDate** | **DateTime?** | Date and time when the affiliate is onboarded. If not provided, the system could use the current date-time. | [optional] 
**IsActive** | **bool?** | Indicates whether the affiliate should start as active. Defaults to true if not provided. | [optional] [default to true]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

