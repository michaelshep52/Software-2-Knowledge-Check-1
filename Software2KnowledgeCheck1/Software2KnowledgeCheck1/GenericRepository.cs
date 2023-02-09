using System;
namespace Software2KnowledgeCheck1
{
    public class GenericRepository<T>
    {
        private readonly List<T> _items = new();

        public void CreateHousing(T item)
        {
            // Get materials
            var materialRepo = new MaterialsRepo();
            var materialsNeeded = materialRepo.GetMaterials();

            var permitRepo = new ZoningAndPermitRepo();

            var housingWasMade = ConstructBuilding(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves());

            if (housingWasMade)
            {
                _items.Add(item);
            }
        }

        public bool ConstructBuilding(List<string> materials, bool permit, bool zoning)
        {
            if (permit && zoning)
            {
                foreach (var material in materials)
                {
                    if (material == "concrete")
                    {
                        // start laying foundation
                    }
                    else if (material == "Steel")
                    {
                        // Start building structure
                    }
                    // etc etc...

                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

