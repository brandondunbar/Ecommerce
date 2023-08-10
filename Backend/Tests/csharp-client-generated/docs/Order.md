# IO.Swagger.Model.Order
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long?** | Unique identifier for the order. | [optional] 
**OrderDate** | **DateTime?** | Date and time when the order was placed. | [optional] 
**Status** | **string** | Current status of the order. | [optional] 
**Items** | [**List&lt;OrderItem&gt;**](OrderItem.md) | List of products/items in the order. | [optional] 
**TotalAmount** | **float?** | Total amount of the order. | [optional] 
**ShippingAddress** | [**Address**](Address.md) |  | [optional] 
**PaymentMethod** | **string** | Payment method used for the order (e.g., \&quot;Credit Card\&quot;, \&quot;PayPal\&quot;). | [optional] 
**TrackingNumber** | **string** | Tracking number for shipped orders. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

