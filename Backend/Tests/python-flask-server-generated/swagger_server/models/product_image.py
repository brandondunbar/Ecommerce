# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server import util


class ProductImage(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, id: str=None, url: str=None, alt_text: str=None, uploaded_at: datetime=None):  # noqa: E501
        """ProductImage - a model defined in Swagger

        :param id: The id of this ProductImage.  # noqa: E501
        :type id: str
        :param url: The url of this ProductImage.  # noqa: E501
        :type url: str
        :param alt_text: The alt_text of this ProductImage.  # noqa: E501
        :type alt_text: str
        :param uploaded_at: The uploaded_at of this ProductImage.  # noqa: E501
        :type uploaded_at: datetime
        """
        self.swagger_types = {
            'id': str,
            'url': str,
            'alt_text': str,
            'uploaded_at': datetime
        }

        self.attribute_map = {
            'id': 'id',
            'url': 'url',
            'alt_text': 'altText',
            'uploaded_at': 'uploadedAt'
        }
        self._id = id
        self._url = url
        self._alt_text = alt_text
        self._uploaded_at = uploaded_at

    @classmethod
    def from_dict(cls, dikt) -> 'ProductImage':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The ProductImage of this ProductImage.  # noqa: E501
        :rtype: ProductImage
        """
        return util.deserialize_model(dikt, cls)

    @property
    def id(self) -> str:
        """Gets the id of this ProductImage.

        Unique identifier for the image.  # noqa: E501

        :return: The id of this ProductImage.
        :rtype: str
        """
        return self._id

    @id.setter
    def id(self, id: str):
        """Sets the id of this ProductImage.

        Unique identifier for the image.  # noqa: E501

        :param id: The id of this ProductImage.
        :type id: str
        """

        self._id = id

    @property
    def url(self) -> str:
        """Gets the url of this ProductImage.

        URL where the image can be accessed.  # noqa: E501

        :return: The url of this ProductImage.
        :rtype: str
        """
        return self._url

    @url.setter
    def url(self, url: str):
        """Sets the url of this ProductImage.

        URL where the image can be accessed.  # noqa: E501

        :param url: The url of this ProductImage.
        :type url: str
        """

        self._url = url

    @property
    def alt_text(self) -> str:
        """Gets the alt_text of this ProductImage.

        Alternative text for the image, useful for accessibility.  # noqa: E501

        :return: The alt_text of this ProductImage.
        :rtype: str
        """
        return self._alt_text

    @alt_text.setter
    def alt_text(self, alt_text: str):
        """Sets the alt_text of this ProductImage.

        Alternative text for the image, useful for accessibility.  # noqa: E501

        :param alt_text: The alt_text of this ProductImage.
        :type alt_text: str
        """

        self._alt_text = alt_text

    @property
    def uploaded_at(self) -> datetime:
        """Gets the uploaded_at of this ProductImage.

        Date and time when the image was uploaded.  # noqa: E501

        :return: The uploaded_at of this ProductImage.
        :rtype: datetime
        """
        return self._uploaded_at

    @uploaded_at.setter
    def uploaded_at(self, uploaded_at: datetime):
        """Sets the uploaded_at of this ProductImage.

        Date and time when the image was uploaded.  # noqa: E501

        :param uploaded_at: The uploaded_at of this ProductImage.
        :type uploaded_at: datetime
        """

        self._uploaded_at = uploaded_at
