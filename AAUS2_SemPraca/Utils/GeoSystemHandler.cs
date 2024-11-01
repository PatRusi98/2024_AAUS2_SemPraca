using AAUS2_SemPraca.Objects;
using AAUS2_SemPraca.Struct;
using static AAUS2_SemPraca.Utils.Enums;

namespace AAUS2_SemPraca.Utils
{
    public class GeoSystemHandler
    {
        private static GeoSystemHandler? _instance = null;
        private KDTree<GeoNode> TreeParcel { get; } = new();
        private KDTree<GeoNode> TreeProperty { get; } = new();
        private KDTree<GeoNode> TreeObjects { get; } = new();

        private GeoSystemHandler() { }

        public static GeoSystemHandler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GeoSystemHandler();
                }
                return _instance;
            }
        }

        public bool Insert(GeoEntity entity)
        {
            var success = false;
            DebugCode message = DebugCode.UnknownEntity;
            if (entity is Parcel parcel)
            {
                (success, message) = TreeParcel.Insert(new GeoNode(parcel.Key1) { Value = parcel });
                (success, message) = TreeParcel.Insert(new GeoNode(parcel.Key2) { Value = parcel });

                (success, message) = TreeObjects.Insert(new GeoNode(parcel.Key1) { Value = parcel });
                (success, message) = TreeObjects.Insert(new GeoNode(parcel.Key2) { Value = parcel });

                parcel.AddSubAreas(SearchOverlapItems(parcel));
            }
            else if (entity is Property property)
            {
                (success, message) = TreeProperty.Insert(new GeoNode(property.Key1) { Value = property });
                (success, message) = TreeProperty.Insert(new GeoNode(property.Key2) { Value = property });

                (success, message) = TreeObjects.Insert(new GeoNode(property.Key1) { Value = property });
                (success, message) = TreeObjects.Insert(new GeoNode(property.Key2) { Value = property });

                property.AddSubAreas(SearchOverlapItems(property));
            }

            return success;
        }

        public bool Update(GeoEntity entityToEdit, GeoEntityParams par)
        {
            var success = false;

            if (par.Number != null)
            {
                entityToEdit.Number = par.Number.Value;
                success = true;
            }

            if (par.Description != null)
            {
                entityToEdit.Description = par.Description;
                success = true;
            }

            if (par.Point1 != null || par.Point2 != null)
            {
                entityToEdit.Point1 = par.Point1 ?? entityToEdit.Point1;
                entityToEdit.Point2 = par.Point2 ?? entityToEdit.Point2;

                entityToEdit.SubAreas = new();
                entityToEdit.AddSubAreas(SearchOverlapItems(entityToEdit));

                success = true;
                // TODO: vymazat a znovu pridat do stromu
            }

            return success;
        }

        public bool Delete(GeoEntity entity)
        {
            var success = false;
            DebugCode message = DebugCode.UnknownEntity;
            if (entity is Parcel parcel)
            {
                (success, message) = TreeParcel.Delete(new GeoNode(parcel.Key1) { Value = parcel });
                (success, message) = TreeParcel.Delete(new GeoNode(parcel.Key2) { Value = parcel });

                (success, message) = TreeObjects.Delete(new GeoNode(parcel.Key1) { Value = parcel });
                (success, message) = TreeObjects.Delete(new GeoNode(parcel.Key2) { Value = parcel });
            }
            else if (entity is Property property)
            {
                (success, message) = TreeProperty.Delete(new GeoNode(property.Key1) { Value = property });
                (success, message) = TreeProperty.Delete(new GeoNode(property.Key2) { Value = property });

                (success, message) = TreeObjects.Delete(new GeoNode(property.Key1) { Value = property });
                (success, message) = TreeObjects.Delete(new GeoNode(property.Key2) { Value = property });
            }

            return success;
        }

        public List<GeoEntity> Search(GPSLocation gps, GeoEntityType type = GeoEntityType.Unknown)
        {
            var returnedNodes = new List<GeoNode>();
            var result = new List<GeoEntity>();

            if (type == GeoEntityType.Parcel)
                returnedNodes.AddRange(TreeParcel.Search(new GeoNode(gps.GPSToDouble()))!);
            else if (type == GeoEntityType.Property)
                returnedNodes.AddRange(TreeProperty.Search(new GeoNode(gps.GPSToDouble()))!);
            else
                returnedNodes.AddRange(TreeObjects.Search(new GeoNode(gps.GPSToDouble()))!);

            foreach (var node in returnedNodes)
            {
                if (node.Value != null)
                    result.Add(node.Value);
            }

            return result;
        }

        public List<GeoEntity> SearchAll(GeoEntityType type = GeoEntityType.Unknown)
        {
            var returnedNodes = new List<GeoNode>();
            var result = new List<GeoEntity>();

            if (type == GeoEntityType.Parcel)
                returnedNodes.AddRange(TreeParcel.GetAllItems()!);
            else if (type == GeoEntityType.Property)
                returnedNodes.AddRange(TreeProperty.GetAllItems()!);
            else
                returnedNodes.AddRange(TreeObjects.GetAllItems()!);

            foreach (var node in returnedNodes)
            {
                if (node.Value != null && !result.Any(x => x.ID == node.Value.ID)) // len ak sa tam este nenachadza (kvoli tomu, ze ich vkladame 2x)
                    result.Add(node.Value);
            }

            return result;
        }

        public void SaveToFile()
        {
            var allItems = SearchAll(GeoEntityType.Unknown);
            
            using (StreamWriter writer = new StreamWriter("")) // TODO: path
            {
                foreach (var item in allItems)
                {
                    writer.WriteLine(item.ToString());
                }
            }
        }

        #region private
        private List<GeoEntity> SearchOverlapItems(GeoEntity entity)
        {
            var overlapList = new List<GeoEntity>();

            if (entity is Parcel parcel)
            {
                overlapList.AddRange(Search(parcel.Point1, GeoEntityType.Property));
                overlapList.AddRange(Search(parcel.Point2, GeoEntityType.Property));
            }
            else if (entity is Property property)
            {
                overlapList.AddRange(Search(property.Point1, GeoEntityType.Parcel));
                overlapList.AddRange(Search(property.Point2, GeoEntityType.Parcel));
            }

            return overlapList;
        }
        #endregion
    }
}
