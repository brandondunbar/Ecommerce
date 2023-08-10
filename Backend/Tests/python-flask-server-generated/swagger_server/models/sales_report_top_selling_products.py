# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server import util


class SalesReportTopSellingProducts(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, product_id: int=None, product_name: str=None, quantity_sold: int=None):  # noqa: E501
        """SalesReportTopSellingProducts - a model defined in Swagger

        :param product_id: The product_id of this SalesReportTopSellingProducts.  # noqa: E501
        :type product_id: int
        :param product_name: The product_name of this SalesReportTopSellingProducts.  # noqa: E501
        :type product_name: str
        :param quantity_sold: The quantity_sold of this SalesReportTopSellingProducts.  # noqa: E501
        :type quantity_sold: int
        """
        self.swagger_types = {
            'product_id': int,
            'product_name': str,
            'quantity_sold': int
        }

        self.attribute_map = {
            'product_id': 'productId',
            'product_name': 'productName',
            'quantity_sold': 'quantitySold'
        }
        self._product_id = product_id
        self._product_name = product_name
        self._quantity_sold = quantity_sold

    @classmethod
    def from_dict(cls, dikt) -> 'SalesReportTopSellingProducts':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The SalesReport_topSellingProducts of this SalesReportTopSellingProducts.  # noqa: E501
        :rtype: SalesReportTopSellingProducts
        """
        return util.deserialize_model(dikt, cls)

    @property
    def product_id(self) -> int:
        """Gets the product_id of this SalesReportTopSellingProducts.

        Unique identifier for the product.  # noqa: E501

        :return: The product_id of this SalesReportTopSellingProducts.
        :rtype: int
        """
        return self._product_id

    @product_id.setter
    def product_id(self, product_id: int):
        """Sets the product_id of this SalesReportTopSellingProducts.

        Unique identifier for the product.  # noqa: E501

        :param product_id: The product_id of this SalesReportTopSellingProducts.
        :type product_id: int
        """

        self._product_id = product_id

    @property
    def product_name(self) -> str:
        """Gets the product_name of this SalesReportTopSellingProducts.

        Name of the product.  # noqa: E501

        :return: The product_name of this SalesReportTopSellingProducts.
        :rtype: str
        """
        return self._product_name

    @product_name.setter
    def product_name(self, product_name: str):
        """Sets the product_name of this SalesReportTopSellingProducts.

        Name of the product.  # noqa: E501

        :param product_name: The product_name of this SalesReportTopSellingProducts.
        :type product_name: str
        """

        self._product_name = product_name

    @property
    def quantity_sold(self) -> int:
        """Gets the quantity_sold of this SalesReportTopSellingProducts.

        Total quantity of this product sold during the report period.  # noqa: E501

        :return: The quantity_sold of this SalesReportTopSellingProducts.
        :rtype: int
        """
        return self._quantity_sold

    @quantity_sold.setter
    def quantity_sold(self, quantity_sold: int):
        """Sets the quantity_sold of this SalesReportTopSellingProducts.

        Total quantity of this product sold during the report period.  # noqa: E501

        :param quantity_sold: The quantity_sold of this SalesReportTopSellingProducts.
        :type quantity_sold: int
        """

        self._quantity_sold = quantity_sold