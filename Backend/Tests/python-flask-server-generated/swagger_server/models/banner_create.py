# coding: utf-8

from __future__ import absolute_import
from datetime import date, datetime  # noqa: F401

from typing import List, Dict  # noqa: F401

from swagger_server.models.base_model_ import Model
from swagger_server import util


class BannerCreate(Model):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    def __init__(self, title: str=None, image_url: str=None, link_url: str=None, display_duration: int=None, start_date: datetime=None, end_date: datetime=None, position: str=None, is_active: bool=None):  # noqa: E501
        """BannerCreate - a model defined in Swagger

        :param title: The title of this BannerCreate.  # noqa: E501
        :type title: str
        :param image_url: The image_url of this BannerCreate.  # noqa: E501
        :type image_url: str
        :param link_url: The link_url of this BannerCreate.  # noqa: E501
        :type link_url: str
        :param display_duration: The display_duration of this BannerCreate.  # noqa: E501
        :type display_duration: int
        :param start_date: The start_date of this BannerCreate.  # noqa: E501
        :type start_date: datetime
        :param end_date: The end_date of this BannerCreate.  # noqa: E501
        :type end_date: datetime
        :param position: The position of this BannerCreate.  # noqa: E501
        :type position: str
        :param is_active: The is_active of this BannerCreate.  # noqa: E501
        :type is_active: bool
        """
        self.swagger_types = {
            'title': str,
            'image_url': str,
            'link_url': str,
            'display_duration': int,
            'start_date': datetime,
            'end_date': datetime,
            'position': str,
            'is_active': bool
        }

        self.attribute_map = {
            'title': 'title',
            'image_url': 'imageUrl',
            'link_url': 'linkUrl',
            'display_duration': 'displayDuration',
            'start_date': 'startDate',
            'end_date': 'endDate',
            'position': 'position',
            'is_active': 'isActive'
        }
        self._title = title
        self._image_url = image_url
        self._link_url = link_url
        self._display_duration = display_duration
        self._start_date = start_date
        self._end_date = end_date
        self._position = position
        self._is_active = is_active

    @classmethod
    def from_dict(cls, dikt) -> 'BannerCreate':
        """Returns the dict as a model

        :param dikt: A dict.
        :type: dict
        :return: The BannerCreate of this BannerCreate.  # noqa: E501
        :rtype: BannerCreate
        """
        return util.deserialize_model(dikt, cls)

    @property
    def title(self) -> str:
        """Gets the title of this BannerCreate.

        A short title or headline for the banner.  # noqa: E501

        :return: The title of this BannerCreate.
        :rtype: str
        """
        return self._title

    @title.setter
    def title(self, title: str):
        """Sets the title of this BannerCreate.

        A short title or headline for the banner.  # noqa: E501

        :param title: The title of this BannerCreate.
        :type title: str
        """
        if title is None:
            raise ValueError("Invalid value for `title`, must not be `None`")  # noqa: E501

        self._title = title

    @property
    def image_url(self) -> str:
        """Gets the image_url of this BannerCreate.

        URL of the banner image.  # noqa: E501

        :return: The image_url of this BannerCreate.
        :rtype: str
        """
        return self._image_url

    @image_url.setter
    def image_url(self, image_url: str):
        """Sets the image_url of this BannerCreate.

        URL of the banner image.  # noqa: E501

        :param image_url: The image_url of this BannerCreate.
        :type image_url: str
        """
        if image_url is None:
            raise ValueError("Invalid value for `image_url`, must not be `None`")  # noqa: E501

        self._image_url = image_url

    @property
    def link_url(self) -> str:
        """Gets the link_url of this BannerCreate.

        URL to which the banner redirects when clicked.  # noqa: E501

        :return: The link_url of this BannerCreate.
        :rtype: str
        """
        return self._link_url

    @link_url.setter
    def link_url(self, link_url: str):
        """Sets the link_url of this BannerCreate.

        URL to which the banner redirects when clicked.  # noqa: E501

        :param link_url: The link_url of this BannerCreate.
        :type link_url: str
        """
        if link_url is None:
            raise ValueError("Invalid value for `link_url`, must not be `None`")  # noqa: E501

        self._link_url = link_url

    @property
    def display_duration(self) -> int:
        """Gets the display_duration of this BannerCreate.

        Duration (in seconds) for which the banner should be displayed to the user.  # noqa: E501

        :return: The display_duration of this BannerCreate.
        :rtype: int
        """
        return self._display_duration

    @display_duration.setter
    def display_duration(self, display_duration: int):
        """Sets the display_duration of this BannerCreate.

        Duration (in seconds) for which the banner should be displayed to the user.  # noqa: E501

        :param display_duration: The display_duration of this BannerCreate.
        :type display_duration: int
        """

        self._display_duration = display_duration

    @property
    def start_date(self) -> datetime:
        """Gets the start_date of this BannerCreate.

        Date and time when the banner starts being displayed.  # noqa: E501

        :return: The start_date of this BannerCreate.
        :rtype: datetime
        """
        return self._start_date

    @start_date.setter
    def start_date(self, start_date: datetime):
        """Sets the start_date of this BannerCreate.

        Date and time when the banner starts being displayed.  # noqa: E501

        :param start_date: The start_date of this BannerCreate.
        :type start_date: datetime
        """
        if start_date is None:
            raise ValueError("Invalid value for `start_date`, must not be `None`")  # noqa: E501

        self._start_date = start_date

    @property
    def end_date(self) -> datetime:
        """Gets the end_date of this BannerCreate.

        Date and time when the banner stops being displayed.  # noqa: E501

        :return: The end_date of this BannerCreate.
        :rtype: datetime
        """
        return self._end_date

    @end_date.setter
    def end_date(self, end_date: datetime):
        """Sets the end_date of this BannerCreate.

        Date and time when the banner stops being displayed.  # noqa: E501

        :param end_date: The end_date of this BannerCreate.
        :type end_date: datetime
        """
        if end_date is None:
            raise ValueError("Invalid value for `end_date`, must not be `None`")  # noqa: E501

        self._end_date = end_date

    @property
    def position(self) -> str:
        """Gets the position of this BannerCreate.

        The position on the webpage where the banner should be displayed.  # noqa: E501

        :return: The position of this BannerCreate.
        :rtype: str
        """
        return self._position

    @position.setter
    def position(self, position: str):
        """Sets the position of this BannerCreate.

        The position on the webpage where the banner should be displayed.  # noqa: E501

        :param position: The position of this BannerCreate.
        :type position: str
        """
        allowed_values = ["TOP", "MIDDLE", "BOTTOM"]  # noqa: E501
        if position not in allowed_values:
            raise ValueError(
                "Invalid value for `position` ({0}), must be one of {1}"
                .format(position, allowed_values)
            )

        self._position = position

    @property
    def is_active(self) -> bool:
        """Gets the is_active of this BannerCreate.

        Indicates whether the banner should start as active and be displayed to users.  # noqa: E501

        :return: The is_active of this BannerCreate.
        :rtype: bool
        """
        return self._is_active

    @is_active.setter
    def is_active(self, is_active: bool):
        """Sets the is_active of this BannerCreate.

        Indicates whether the banner should start as active and be displayed to users.  # noqa: E501

        :param is_active: The is_active of this BannerCreate.
        :type is_active: bool
        """

        self._is_active = is_active
