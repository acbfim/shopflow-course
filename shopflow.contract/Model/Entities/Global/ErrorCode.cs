using System.ComponentModel;

namespace shopflow.contract.Model.Entities.Global
{
    public enum ErrorCode
    {   
        [Description("Error on perform the action")]
        GENERIC_ERROR,

        [Description("Error on database. The entity was not found with the specified paramenters")]
        ENTITY_NOT_FOUND
    }
}