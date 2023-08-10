# IO.Swagger.Model.InventoryItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductId** | **long?** | Unique identifier for the product. | 
**ProductName** | **string** | Name of the product. | 
**CurrentStock** | **int?** | The current stock level for the product. | 
**RestockThreshold** | **int?** | The threshold at which a restock alert is triggered. When the current stock drops below this value, a restock might be necessary. | [optional] 
**LastRestockDate** | **DateTime?** | The date and time when the product was last restocked. | [optional] 
**NextRestockDate** | **DateTime?** | Estimated date and time for the next restocking, if applicable. | [optional] 
**Supplier** | **string** | The supplier or manufacturer of the product. | [optional] 
**Notes** | **string** | Any additional notes or comments about the inventory item. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

