using System.Collections.Generic;
using CategoryTreeGenerator.Models;

namespace CategoryTreeGenerator.Sources
{
    public class MockDataSource : IDataSource
    {
        public IEnumerable<Location> Locations { get; set; }

        public IEnumerable<Tag> Tags { get; }

        public IEnumerable<Type> Types { get; }

        public MockDataSource()
        {
            Tags = new List<Tag>
            {
                new Tag("coastal", "coastal", "�� ����", false, 1),
                new Tag("cheap", "cheap property", "�������", false, 1),
                new Tag("with-swimming-pool", "with pool", "� ���������", false, 2),
                new Tag("marine", "marine", "������������ �� ����", false, 2),
                new Tag("by-owner", "by owner", "�� ���������", true, 3),
                new Tag("from-developer", "from developer", "�� �����������", true, 3)
            };

            Types = new List<Type>
            {
                new Type("property-for-sale", "Property for sale", "�������"),
                new Type("property-for-rent", "Property for rent", "������"),
                new Type("apartments-for-sale", "Apartments for sale", "�����������"),
                new Type("apartments-for-rent", "Apartments for rent", "�����������"),
                new Type("lofts-for-sale", "Loft for sale", "����","apartments-for-sale"),
                new Type("lofts-for-rent", "Loft for rent", "����", "apartments-for-rent")
            };

            Locations = new List<Location>
            {
                new Location
                {
                    Coast = new LocationDetails("costa-blanca", "Costa Blanca", "����� ������"),
                    Province = new LocationDetails("alicante", "Alicante province", "��������"),
                    Area = new LocationDetails("marina-alta", "Marina Alta", "������-�����"),
                    City = new LocationDetails("denia", "Denia", "�����"),
                    EndLocation = null,
                    EndLocation2 = null
                },
                new Location
                {
                    Coast = new LocationDetails("costa-blanca", "Costa Blanca", "����� ������"),
                    Province = new LocationDetails("alicante", "Alicante province", "��������"),
                    Area = new LocationDetails("marina-alta", "Marina Alta", "������-�����"),
                    City = new LocationDetails("benissa", "Benissa", "�������"),
                    EndLocation = new LocationDetails("cala-advocat-baladrar", "Cala Advocat - Baladrar","���� ������� - �������"),
                    EndLocation2 = null
                }
            };
        }
    }
}
