using System;
using Parquet.Meta;

namespace Parquet.Schema {
    /// <summary>
    /// Schema element for <see cref="DateTime"/> which allows to specify precision that matches LogicalType Timestamp
    /// </summary>
    public class TimestampDataField : DataField {
        /// <summary>
        /// IsAdjustedToUTC
        /// </summary>
        public bool IsAdjustedToUTC { get; }

        /// <summary>
        /// Unit
        /// </summary>
        public Types.TimeUnit Unit { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeDataField"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="unit"></param>
        /// <param name="isAdjustedToUTC"></param>
        /// <param name="isNullable"></param>
        /// <param name="isArray"></param>
        /// <param name="propertyName">When set, uses this property to get the field's data.  When not set, uses the property that matches the name parameter.</param>
        public TimestampDataField(string name, Types.TimeUnit unit = Types.TimeUnit.MILLIS, bool isAdjustedToUTC = true,
            bool? isNullable = null, bool? isArray = null, string? propertyName = null)
            : base(name, typeof(DateTime), isNullable, isArray, propertyName) {
            IsAdjustedToUTC = isAdjustedToUTC;
            Unit = unit;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class Types {
        /// <summary>
        /// 
        /// </summary>
        public enum TimeUnit {
            /// <summary>
            /// 
            /// </summary>
            MILLIS,

            /// <summary>
            /// 
            /// </summary>
            MICROS,

            /// <summary>
            /// 
            /// </summary>
            NANOS,
        }
    }
}