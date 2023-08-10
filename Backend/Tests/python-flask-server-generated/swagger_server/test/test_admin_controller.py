# coding: utf-8

from __future__ import absolute_import

from flask import json
from six import BytesIO

from swagger_server.models.admin_notifications_body import AdminNotificationsBody  # noqa: E501
from swagger_server.models.affiliate import Affiliate  # noqa: E501
from swagger_server.models.affiliate_create import AffiliateCreate  # noqa: E501
from swagger_server.models.banner import Banner  # noqa: E501
from swagger_server.models.banner_create import BannerCreate  # noqa: E501
from swagger_server.models.content_page import ContentPage  # noqa: E501
from swagger_server.models.feedback import Feedback  # noqa: E501
from swagger_server.models.feedback_update import FeedbackUpdate  # noqa: E501
from swagger_server.models.inventory_item import InventoryItem  # noqa: E501
from swagger_server.models.inventory_update import InventoryUpdate  # noqa: E501
from swagger_server.models.monitoring_metric import MonitoringMetric  # noqa: E501
from swagger_server.models.order import Order  # noqa: E501
from swagger_server.models.order_update import OrderUpdate  # noqa: E501
from swagger_server.models.partnership import Partnership  # noqa: E501
from swagger_server.models.partnership_create import PartnershipCreate  # noqa: E501
from swagger_server.models.platform_settings import PlatformSettings  # noqa: E501
from swagger_server.models.platform_settings_update import PlatformSettingsUpdate  # noqa: E501
from swagger_server.models.promotion import Promotion  # noqa: E501
from swagger_server.models.promotion_update import PromotionUpdate  # noqa: E501
from swagger_server.models.review import Review  # noqa: E501
from swagger_server.models.review_update import ReviewUpdate  # noqa: E501
from swagger_server.models.sales_report import SalesReport  # noqa: E501
from swagger_server.models.system_log import SystemLog  # noqa: E501
from swagger_server.models.user import User  # noqa: E501
from swagger_server.models.user_activity_report import UserActivityReport  # noqa: E501
from swagger_server.models.user_id_bans_body import UserIdBansBody  # noqa: E501
from swagger_server.models.user_registration import UserRegistration  # noqa: E501
from swagger_server.models.user_update import UserUpdate  # noqa: E501
from swagger_server.test import BaseTestCase


class TestAdminController(BaseTestCase):
    """AdminController integration test stubs"""

    def test_api_admin_affiliates_get(self):
        """Test case for api_admin_affiliates_get

        Retrieve a list of affiliates
        """
        response = self.client.open(
            '/api/admin/affiliates',
            method='GET')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_affiliates_post(self):
        """Test case for api_admin_affiliates_post

        Add a new affiliate
        """
        body = AffiliateCreate()
        response = self.client.open(
            '/api/admin/affiliates',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_content_banners_get(self):
        """Test case for api_admin_content_banners_get

        Retrieve a list of promotional banners
        """
        response = self.client.open(
            '/api/admin/content/banners',
            method='GET')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_content_banners_post(self):
        """Test case for api_admin_content_banners_post

        Create a new promotional banner
        """
        body = BannerCreate()
        response = self.client.open(
            '/api/admin/content/banners',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_content_pages_get(self):
        """Test case for api_admin_content_pages_get

        Retrieve a list of content pages
        """
        response = self.client.open(
            '/api/admin/content/pages',
            method='GET')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_feedback_get(self):
        """Test case for api_admin_feedback_get

        Retrieve a list of user feedback
        """
        query_string = [('status', 'status_example'),
                        ('type', 'type_example'),
                        ('page', 56),
                        ('limit', 56)]
        response = self.client.open(
            '/api/admin/feedback',
            method='GET',
            query_string=query_string)
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_feedback_put(self):
        """Test case for api_admin_feedback_put

        Update feedback details
        """
        body = FeedbackUpdate()
        response = self.client.open(
            '/api/admin/feedback',
            method='PUT',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_inventory_get(self):
        """Test case for api_admin_inventory_get

        List all inventory items
        """
        query_string = [('below_threshold', 56)]
        response = self.client.open(
            '/api/admin/inventory',
            method='GET',
            query_string=query_string)
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_inventory_put(self):
        """Test case for api_admin_inventory_put

        Bulk update inventory
        """
        body = [InventoryUpdate()]
        response = self.client.open(
            '/api/admin/inventory',
            method='PUT',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_logs_get(self):
        """Test case for api_admin_logs_get

        Retrieve system logs
        """
        query_string = [('start_date', '2013-10-20'),
                        ('end_date', '2013-10-20'),
                        ('log_level', 'log_level_example'),
                        ('event', 'event_example')]
        response = self.client.open(
            '/api/admin/logs',
            method='GET',
            query_string=query_string)
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_monitoring_get(self):
        """Test case for api_admin_monitoring_get

        Retrieve system monitoring data
        """
        query_string = [('start_time', '2013-10-20T19:20:30+01:00'),
                        ('end_time', '2013-10-20T19:20:30+01:00'),
                        ('metric', 'metric_example')]
        response = self.client.open(
            '/api/admin/monitoring',
            method='GET',
            query_string=query_string)
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_notifications_post(self):
        """Test case for api_admin_notifications_post

        Send a notification to a user
        """
        body = AdminNotificationsBody()
        response = self.client.open(
            '/api/admin/notifications',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_orders_get(self):
        """Test case for api_admin_orders_get

        List all orders
        """
        query_string = [('status', 'status_example'),
                        ('from_date', '2013-10-20'),
                        ('to_date', '2013-10-20')]
        response = self.client.open(
            '/api/admin/orders',
            method='GET',
            query_string=query_string)
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_orders_put(self):
        """Test case for api_admin_orders_put

        Bulk update orders
        """
        body = [OrderUpdate()]
        response = self.client.open(
            '/api/admin/orders',
            method='PUT',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_partnerships_get(self):
        """Test case for api_admin_partnerships_get

        Retrieve a list of business partnerships
        """
        response = self.client.open(
            '/api/admin/partnerships',
            method='GET')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_partnerships_post(self):
        """Test case for api_admin_partnerships_post

        Add a new business partnership
        """
        body = PartnershipCreate()
        response = self.client.open(
            '/api/admin/partnerships',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_promotions_delete(self):
        """Test case for api_admin_promotions_delete

        Delete a promotion
        """
        query_string = [('promotion_id', 56)]
        response = self.client.open(
            '/api/admin/promotions',
            method='DELETE',
            query_string=query_string)
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_promotions_get(self):
        """Test case for api_admin_promotions_get

        List all active promotions
        """
        response = self.client.open(
            '/api/admin/promotions',
            method='GET')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_promotions_post(self):
        """Test case for api_admin_promotions_post

        Create a new promotion
        """
        body = Promotion()
        response = self.client.open(
            '/api/admin/promotions',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_promotions_put(self):
        """Test case for api_admin_promotions_put

        Bulk update promotions
        """
        body = [PromotionUpdate()]
        response = self.client.open(
            '/api/admin/promotions',
            method='PUT',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_reports_sales_get(self):
        """Test case for api_admin_reports_sales_get

        Generate and retrieve a sales report
        """
        query_string = [('start_date', '2013-10-20'),
                        ('end_date', '2013-10-20'),
                        ('granularity', 'granularity_example')]
        response = self.client.open(
            '/api/admin/reports/sales',
            method='GET',
            query_string=query_string)
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_reports_user_activity_get(self):
        """Test case for api_admin_reports_user_activity_get

        Generate and retrieve a user activity report
        """
        query_string = [('start_date', '2013-10-20'),
                        ('end_date', '2013-10-20'),
                        ('granularity', 'granularity_example')]
        response = self.client.open(
            '/api/admin/reports/user-activity',
            method='GET',
            query_string=query_string)
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_reviews_delete(self):
        """Test case for api_admin_reviews_delete

        Delete a specific review
        """
        response = self.client.open(
            '/api/admin/reviews'.format(review_id=789),
            method='DELETE')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_reviews_get(self):
        """Test case for api_admin_reviews_get

        Retrieve a list of product reviews
        """
        query_string = [('product_id', 789),
                        ('user_id', 789),
                        ('status', 'status_example'),
                        ('page', 56),
                        ('limit', 56)]
        response = self.client.open(
            '/api/admin/reviews',
            method='GET',
            query_string=query_string)
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_reviews_put(self):
        """Test case for api_admin_reviews_put

        Update the status of a review
        """
        body = ReviewUpdate()
        response = self.client.open(
            '/api/admin/reviews',
            method='PUT',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_settings_get(self):
        """Test case for api_admin_settings_get

        Retrieve platform settings
        """
        response = self.client.open(
            '/api/admin/settings',
            method='GET')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_settings_put(self):
        """Test case for api_admin_settings_put

        Update platform settings
        """
        body = PlatformSettingsUpdate()
        response = self.client.open(
            '/api/admin/settings',
            method='PUT',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_users_delete(self):
        """Test case for api_admin_users_delete

        Bulk delete users
        """
        body = [56]
        response = self.client.open(
            '/api/admin/users',
            method='DELETE',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_users_get(self):
        """Test case for api_admin_users_get

        List all users
        """
        response = self.client.open(
            '/api/admin/users',
            method='GET')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_users_post(self):
        """Test case for api_admin_users_post

        Add a new user
        """
        body = UserRegistration()
        response = self.client.open(
            '/api/admin/users',
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_users_put(self):
        """Test case for api_admin_users_put

        Bulk update users
        """
        body = [UserUpdate()]
        response = self.client.open(
            '/api/admin/users',
            method='PUT',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_users_user_id_bans_delete(self):
        """Test case for api_admin_users_user_id_bans_delete

        Unban a specific user
        """
        response = self.client.open(
            '/api/admin/users/{userId}/bans'.format(user_id=56),
            method='DELETE')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_users_user_id_bans_post(self):
        """Test case for api_admin_users_user_id_bans_post

        Ban a specific user
        """
        body = UserIdBansBody()
        response = self.client.open(
            '/api/admin/users/{userId}/bans'.format(user_id=56),
            method='POST',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_users_user_id_roles_delete(self):
        """Test case for api_admin_users_user_id_roles_delete

        Remove roles from a specific user
        """
        body = ['body_example']
        response = self.client.open(
            '/api/admin/users/{userId}/roles'.format(user_id=56),
            method='DELETE',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_users_user_id_roles_get(self):
        """Test case for api_admin_users_user_id_roles_get

        List roles for a specific user
        """
        response = self.client.open(
            '/api/admin/users/{userId}/roles'.format(user_id=56),
            method='GET')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))

    def test_api_admin_users_user_id_roles_put(self):
        """Test case for api_admin_users_user_id_roles_put

        Assign or update roles for a specific user
        """
        body = ['body_example']
        response = self.client.open(
            '/api/admin/users/{userId}/roles'.format(user_id=56),
            method='PUT',
            data=json.dumps(body),
            content_type='application/json')
        self.assert200(response,
                       'Response body is : ' + response.data.decode('utf-8'))


if __name__ == '__main__':
    import unittest
    unittest.main()
