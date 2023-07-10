using AutoMapper;
using System.Reflection;

namespace BusinessModel
{
    /// <summary>
    /// Class for Conversion method for DataModel to BusinessModel 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class ObjectExtensionMethods
    {
        
       
        /// <summary>
        /// Copy properties from parent to self
        /// </summary>
        /// <param name="self"></param>
        /// <param name="parent"></param>
        public static void CopyPropertiesFrom(this object self, object parent)
        {
            var fromProperties = parent.GetType().GetProperties();
            var toProperties = self.GetType().GetProperties();

            foreach (var fromProperty in fromProperties)
            {
                foreach (var toProperty in toProperties)
                {
                    if (fromProperty.Name == toProperty.Name && fromProperty.PropertyType == toProperty.PropertyType)
                    {
                        toProperty.SetValue(self, fromProperty.GetValue(parent));
                        break;
                    }
                }
            }
        }
        ////////public static void MatchPropertiesFrom(this object self, BusinessModel.Users parent)
        ////////{
        ////////    var childProperties = self.GetType().GetProperties();
        ////////    foreach (var childProperty in childProperties)
        ////////    {
        ////////        var attributesForProperty = childProperty.GetCustomAttributes(typeof(MatchParentAttribute), true);
        ////////        var isOfTypeMatchParentAttribute = false;

        ////////        MatchParentAttribute currentAttribute = null;

        ////////        foreach (var attribute in attributesForProperty)
        ////////        {
        ////////            if (attribute.GetType() == typeof(MatchParentAttribute))
        ////////            {
        ////////                isOfTypeMatchParentAttribute = true;
        ////////                currentAttribute = (MatchParentAttribute)attribute;
        ////////                break;
        ////////            }
        ////////        }

        ////////        if (isOfTypeMatchParentAttribute)
        ////////        {
        ////////            var parentProperties = parent.GetType().GetProperties();
        ////////            object parentPropertyValue = null;
        ////////            foreach (var parentProperty in parentProperties)
        ////////            {
        ////////                if (parentProperty.Name == currentAttribute.ParentPropertyName)
        ////////                {
        ////////                    if (parentProperty.PropertyType == childProperty.PropertyType)
        ////////                    {
        ////////                        parentPropertyValue = parentProperty.GetValue(parent);
        ////////                    }
        ////////                }
        ////////            }
        ////////            childProperty.SetValue(self, parentPropertyValue);
        ////////        }
        ////////    }
        ////////}
        
        /// <summary>
        ///  class for Conversionn from  BusinessModel to DataModel
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        //public DataModels.Users ConvertIntoDataModel(BusinessModel.Users user)
        //{

        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        here create map is the generic method
        //        cfg.CreateMap<BusinessModel.Users, DataModels.Users>();
        //    });
        //    we are passing source properties(user of business) to the destination properties(user of datamodels)
        //    var mapper = new Mapper(config);
        //    return mapper.Map<DataModels.Users>(user);

        //}


        //public BusinessModel.Users ConvertIntoBusinessModel(DataModels.Users user)
        //{
        //    var config = new MapperConfiguration(cfg =>
        //    {
        //        here create map is the generic method
        //        cfg.CreateMap<DataModels.Users, BusinessModel.Users>();
        //    });
        //    var mapper = new Mapper(config);
        //    we are passing source properties(user of datamodels) to the destination properties(user of business)
        //    return mapper.Map<BusinessModel.Users>(user);
        //}
    }
    }

