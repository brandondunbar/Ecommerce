# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server import util


class ProductInventoryUpdate(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, stock_level: int=None, status: str=None):  # noqa: E501
        """ProductInventoryUpdate - a model defined in Swagger

        :param stock_level: The stock_level of this ProductInventoryUpdate.  # noqa: E501
        :type stock_level: int
        :param status: The status of this ProductInventoryUpdate.  # noqa: E501
        :type status: str
        """
        self.swagger_types = {
            'stock_level': int,
            'status': str
        }

        self.attribute_map = {
            'stock_level': 'stockLevel',
            'status': 'status'
        }
        self._stock_level = stock_level
        self._status = status

    @classmethod
    def from_dict(cls, dikt) -> 'ProductInventoryUpdate':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The ProductInventoryUpdate of this ProductInventoryUpdate.  # noqa: E501
        :rtype: ProductInventoryUpdate
        """
        return util.deserialize_model(dikt, cls)

    @property
    def stock_level(self) -> int:
        """Gets the stock_level of this ProductInventoryUpdate.

        Updated number of items in stock.  # noqa: E501

        :return: The stock_level of this ProductInventoryUpdate.
        :rtype: int
        """
        return self._stock_level

    @stock_level.setter
    def stock_level(self, stock_level: int):
        """Sets the stock_level of this ProductInventoryUpdate.

        Updated number of items in stock.  # noqa: E501

        :param stock_level: The stock_level of this ProductInventoryUpdate.
        :type stock_level: int
        """

        self._stock_level = stock_level

    @property
    def status(self) -> str:
        """Gets the status of this ProductInventoryUpdate.

        Updated inventory status.  # noqa: E501

        :return: The status of this ProductInventoryUpdate.
        :rtype: str
        """
        return self._status

    @status.setter
    def status(self, status: str):
        """Sets the status of this ProductInventoryUpdate.

        Updated inventory status.  # noqa: E501

        :param status: The status of this ProductInventoryUpdate.
        :type status: str
        """
        allowed_values = ["in_stock", "low_stock", "out_of_stock"]  # noqa: E501
        if status not in allowed_values:
            raise ValueError(
                "Invalid value for `status` ({0}), must be one of {1}"
                .format(status, allowed_values)
            )

        self._status = status
