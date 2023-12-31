# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server import util


class AdminNotificationsBody(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, user_id: int=None, title: str=None, message: str=None, type: str=None):  # noqa: E501
        """AdminNotificationsBody - a model defined in Swagger

        :param user_id: The user_id of this AdminNotificationsBody.  # noqa: E501
        :type user_id: int
        :param title: The title of this AdminNotificationsBody.  # noqa: E501
        :type title: str
        :param message: The message of this AdminNotificationsBody.  # noqa: E501
        :type message: str
        :param type: The type of this AdminNotificationsBody.  # noqa: E501
        :type type: str
        """
        self.swagger_types = {
            'user_id': int,
            'title': str,
            'message': str,
            'type': str
        }

        self.attribute_map = {
            'user_id': 'userId',
            'title': 'title',
            'message': 'message',
            'type': 'type'
        }
        self._user_id = user_id
        self._title = title
        self._message = message
        self._type = type

    @classmethod
    def from_dict(cls, dikt) -> 'AdminNotificationsBody':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The admin_notifications_body of this AdminNotificationsBody.  # noqa: E501
        :rtype: AdminNotificationsBody
        """
        return util.deserialize_model(dikt, cls)

    @property
    def user_id(self) -> int:
        """Gets the user_id of this AdminNotificationsBody.

        Unique identifier of the target user.  # noqa: E501

        :return: The user_id of this AdminNotificationsBody.
        :rtype: int
        """
        return self._user_id

    @user_id.setter
    def user_id(self, user_id: int):
        """Sets the user_id of this AdminNotificationsBody.

        Unique identifier of the target user.  # noqa: E501

        :param user_id: The user_id of this AdminNotificationsBody.
        :type user_id: int
        """
        if user_id is None:
            raise ValueError("Invalid value for `user_id`, must not be `None`")  # noqa: E501

        self._user_id = user_id

    @property
    def title(self) -> str:
        """Gets the title of this AdminNotificationsBody.

        Title or header of the notification.  # noqa: E501

        :return: The title of this AdminNotificationsBody.
        :rtype: str
        """
        return self._title

    @title.setter
    def title(self, title: str):
        """Sets the title of this AdminNotificationsBody.

        Title or header of the notification.  # noqa: E501

        :param title: The title of this AdminNotificationsBody.
        :type title: str
        """
        if title is None:
            raise ValueError("Invalid value for `title`, must not be `None`")  # noqa: E501

        self._title = title

    @property
    def message(self) -> str:
        """Gets the message of this AdminNotificationsBody.

        Detailed message or content of the notification.  # noqa: E501

        :return: The message of this AdminNotificationsBody.
        :rtype: str
        """
        return self._message

    @message.setter
    def message(self, message: str):
        """Sets the message of this AdminNotificationsBody.

        Detailed message or content of the notification.  # noqa: E501

        :param message: The message of this AdminNotificationsBody.
        :type message: str
        """
        if message is None:
            raise ValueError("Invalid value for `message`, must not be `None`")  # noqa: E501

        self._message = message

    @property
    def type(self) -> str:
        """Gets the type of this AdminNotificationsBody.

        Type or category of the notification (e.g., \"order update\", \"promotion\").  # noqa: E501

        :return: The type of this AdminNotificationsBody.
        :rtype: str
        """
        return self._type

    @type.setter
    def type(self, type: str):
        """Sets the type of this AdminNotificationsBody.

        Type or category of the notification (e.g., \"order update\", \"promotion\").  # noqa: E501

        :param type: The type of this AdminNotificationsBody.
        :type type: str
        """

        self._type = type
