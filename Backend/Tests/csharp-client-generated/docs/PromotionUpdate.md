# IO.Swagger.Model.PromotionUpdate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PromotionId** | **long?** | Unique identifier for the promotion. This is typically used for reference and not for update purposes. | [optional] 
**Name** | **string** | Updated name or title of the promotion. | [optional] 
**Type** | **string** | Type of promotion, e.g., percentage discount, flat discount, etc. | [optional] 
**Value** | [**decimal?**](BigDecimal.md) | The value associated with the promotion. For example, if it&#x27;s a percentage discount, this might be \&quot;10\&quot; for 10%. | [optional] 
**StartDate** | **DateTime?** | Updated start date and time for when the promotion becomes active. | [optional] 
**EndDate** | **DateTime?** | Updated end date and time for when the promotion expires. | [optional] 
**ApplicableProducts** | **List&lt;long?&gt;** | List of product IDs to which the promotion is applicable. If empty, it might be applicable to all products or specific categories. | [optional] 
**Notes** | **string** | Any additional notes or updates about the promotion. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

