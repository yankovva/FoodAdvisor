﻿namespace FoodAdvisor.Constants
{
    public static class EntityValidationConstants
    {
        public static class Location
        {
            public const int NameMinLenght = 2;
            public const int NameMaxLenght = 50;

            public const int DescriptionMinLenght = 20;
            public const int DescriptionMaxLenght = 150;

            public const int AddressMinLenght = 5;
            public const int AddressMaxLenght = 85;

            public const int URLMaxLEnght = 2083;
            public const int URLMinLenght = 8;

        }

        public static class City
        {
            public const int NameMinLenght = 4;
            public const int NameMaxLenght = 56;
        }
        public static class Category
        {
            public const int NameMinLenght = 3;
            public const int NameMaxLenght = 20;

        }

    }
}
