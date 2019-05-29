using CategoryTreeGenerator.Models;
using System.Collections.Generic;

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
                new Tag("coastal", "coastal", "�� ����"),
                new Tag( "in-the-mountains", "in the mountains", "� �����"),
                new Tag("with-swimming-pool", "with pool", "� ���������"),
                new Tag("with-seaview", "seaview", "� ����� �� ����"),
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
                    Costa = new LocationDetails("costa-blanca", "Costa Blanca", "����� ������"),
                    Province = new LocationDetails("alicante", "Alicante province", "��������"),
                    Area = new LocationDetails("marina-alta", "Marina Alta", "������-�����"),
                    City = new LocationDetails("denia", "Denia", "�����"),
                    EndLocation = null,
                    EndLocation2 = null
                },
                new Location
                {
                    Costa = new LocationDetails("costa-blanca", "Costa Blanca", "����� ������"),
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
