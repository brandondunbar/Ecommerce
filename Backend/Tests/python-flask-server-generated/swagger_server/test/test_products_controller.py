# coding: utf-8

from __future__ import absolute_import

from flask import json
from six import BytesIO

from swagger_server.models.category import Category  # noqa: E501
from swagger_server.models.category_input import CategoryInput  # noqa: E501
from swagger_server.models.product import Product  # noqa: E501
from swagger_server.models.product_image import ProductImage  # noqa: E501
from swagger_server.models.product_inventory import ProductInventory  # noqa: E501
from swagger_server.models.product_inventory_update import ProductInventoryUpdate  # noqa: E501
from swagger_server.models.product_price_history_item import ProductPriceHistoryItem  # noqa: E501
from swagger_server.models.product_promotion import ProductPromotion  # noqa: E501
from swagger_server.models.product_update import ProductUpdate  # noqa: E501
from swagger_server.models.review import Review  # noqa: E501
from swagger_server.models.review_input import ReviewInput  # noqa: E501
from swagger_server.test import BaseTestCase


class TestProductsController(BaseTestCase):
    """ProductsController integration test stubs"""

    def test_api_products_batch_update_put(self):
        """Test case for api_products_batch_update_put

        Bulk update products
        """
        body = [ProductUpdate()]
        response = self.client.open(
            '/api/products/batch-update',
            method='PUT',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_products_categories_get(self):
        """Test case for api_products_categories_get

        Retrieve all product categories
        """
        response = self.client.open(
            '/api/products/categories',
            method='GET')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_products_categories_post(self):
        """Test case for api_products_categories_post

        Create a new product category
        """
        body = CategoryInput()
        response = self.client.open(
            '/api/products/categories',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_products_get(self):
        """Test case for api_products_get

        List all products
        """
        query_string = [('page', 56),
                        ('limit', 56),
                        ('sort', 'sort_example')]
        response = self.client.open(
            '/api/products',
            method='GET',
            query_string=query_string)
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_products_post(self):
        """Test case for api_products_post

        Add a new product
        """
        body = Product()
        response = self.client.open(
            '/api/products',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_products_product_id_get(self):
        """Test case for api_products_product_id_get

        Retrieve details of a specific product
        """
        response = self.client.open(
            '/api/products/{productId}'.format(product_id=56),
            method='GET')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_products_product_id_images_delete(self):
        """Test case for api_products_product_id_images_delete

        Delete a specific image for a product
        """
        query_string = [('image_id', 'image_id_example')]
        response = self.client.open(
            '/api/products/{productId}/images'.format(product_id=56),
            method='DELETE',
            query_string=query_string)
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_products_product_id_images_get(self):
        """Test case for api_products_product_id_images_get

        Retrieve images for a specific product
        """
        response = self.client.open(
            '/api/products/{productId}/images'.format(product_id=56),
            method='GET')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_products_product_id_images_post(self):
        """Test case for api_products_product_id_images_post

        Upload a new image for a specific product
        """
        body = Object()
        response = self.client.open(
            '/api/products/{productId}/images'.format(product_id=56),
            method='POST',
            data=json.dumps(body),
            content_type='image/*')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_products_product_id_inventory_get(self):
        """Test case for api_products_product_id_inventory_get

        Retrieve inventory data for a specific product
        """
        response = self.client.open(
            '/api/products/{productId}/inventory'.format(product_id=56),
            method='GET')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_products_product_id_inventory_put(self):
        """Test case for api_products_product_id_inventory_put

        Update inventory data for a specific product
        """
        body = ProductInventoryUpdate()
        response = self.client.open(
            '/api/products/{productId}/inventory'.format(product_id=56),
            method='PUT',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_products_product_id_price_history_get(self):
        """Test case for api_products_product_id_price_history_get

        Retrieve price history for a specific product
        """
        response = self.client.open(
            '/api/products/{productId}/price-history'.format(product_id=56),
            method='GET')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_products_product_id_promotions_get(self):
        """Test case for api_products_product_id_promotions_get

        Retrieve promotions for a specific product
        """
        response = self.client.open(
            '/api/products/{productId}/promotions'.format(product_id=56),
            method='GET')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_products_product_id_related_get(self):
        """Test case for api_products_product_id_related_get

        Retrieve products related to a specific product
        """
        query_string = [('limit', 5)]
        response = self.client.open(
            '/api/products/{productId}/related'.format(product_id=56),
            method='GET',
            query_string=query_string)
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_products_product_id_reviews_get(self):
        """Test case for api_products_product_id_reviews_get

        Retrieve reviews for a specific product
        """
        response = self.client.open(
            '/api/products/{productId}/reviews'.format(product_id=56),
            method='GET')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_products_product_id_reviews_post(self):
        """Test case for api_products_product_id_reviews_post

        Add a review for a specific product
        """
        body = ReviewInput()
        response = self.client.open(
            '/api/products/{productId}/reviews'.format(product_id=56),
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_products_recommendations_get(self):
        """Test case for api_products_recommendations_get

        Retrieve product recommendations for the user
        """
        query_string = [('limit', 10)]
        response = self.client.open(
            '/api/products/recommendations',
            method='GET',
            query_string=query_string)
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_products_search_get(self):
        """Test case for api_products_search_get

        Search for products
        """
        query_string = [('keyword', 'keyword_example'),
                        ('category_id', 56),
                        ('min_price', 3.4),
                        ('max_price', 3.4),
                        ('sort_by', 'sort_by_example'),
                        ('sort_order', 'sort_order_example')]
        response = self.client.open(
            '/api/products/search',
            method='GET',
            query_string=query_string)
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_products_tags_get(self):
        """Test case for api_products_tags_get

        List all product tags
        """
        response = self.client.open(
            '/api/products/tags',
            method='GET')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_products_tags_post(self):
        """Test case for api_products_tags_post

        Add new product tags
        """
        body = ['body_example']
        response = self.client.open(
            '/api/products/tags',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_products_top_rated_get(self):
        """Test case for api_products_top_rated_get

        Retrieve top-rated products
        """
        query_string = [('limit', 10),
                        ('min_reviews_count', 56)]
        response = self.client.open(
            '/api/products/top-rated',
            method='GET',
            query_string=query_string)
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))


if __name__ == '__main__':
    import unittest
    unittest.main()
