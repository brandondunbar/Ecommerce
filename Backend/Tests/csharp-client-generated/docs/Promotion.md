# IO.Swagger.Model.Promotion
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PromotionId** | **long?** | Unique identifier for the promotion. | 
**Name** | **string** | Name or title of the promotion. | 
**Type** | **string** | Type of promotion, e.g., percentage discount, flat discount, etc. | 
**Value** | [**decimal?**](BigDecimal.md) | The value associated with the promotion. For example, if it&#x27;s a percentage discount, this might be \&quot;10\&quot; for 10%. | 
**StartDate** | **DateTime?** | Start date and time for when the promotion becomes active. | 
**EndDate** | **DateTime?** | End date and time for when the promotion expires. | 
**ApplicableProducts** | **List&lt;long?&gt;** | List of product IDs to which the promotion is applicable. If empty, it might be applicable to all products or specific categories. | [optional] 
**Notes** | **string** | Any additional notes or details about the promotion. | [optional] 
**CreatedDate** | **DateTime?** | The date and time when the promotion was created. | [optional] 
**ModifiedDate** | **DateTime?** | The last date and time when the promotion was updated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

