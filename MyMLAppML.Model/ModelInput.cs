// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace MyMLAppML.Model
{
    public class ModelInput
    {
        [ColumnName("date"), LoadColumn(0)]
        public string Date { get; set; } //code behind


        [ColumnName("price"), LoadColumn(1)]
        public float Price { get; set; } //not needed


        [ColumnName("bedrooms"), LoadColumn(2)]
        public float Bedrooms { get; set; } //2


        [ColumnName("bathrooms"), LoadColumn(3)]
        public float Bathrooms { get; set; } //2


        [ColumnName("sqft_living"), LoadColumn(4)]
        public float Sqft_living { get; set; } //3


        [ColumnName("sqft_lot"), LoadColumn(5)]
        public float Sqft_lot { get; set; } //3


        [ColumnName("floors"), LoadColumn(6)]
        public float Floors { get; set; } //2

        [Range(0,1)]
        [ColumnName("waterfront"), LoadColumn(7)]
        public float Waterfront { get; set; } //4

        [Range(1,4)]
        [ColumnName("view"), LoadColumn(8)]
        public float View { get; set; } //4

        [Range(1,5)]
        [ColumnName("condition"), LoadColumn(9)]
        public float Condition { get; set; } //4


        [ColumnName("sqft_above"), LoadColumn(10)]
        public float Sqft_above { get; set; } //3


        [ColumnName("sqft_basement"), LoadColumn(11)]
        public float Sqft_basement { get; set; } //3


        [ColumnName("yr_built"), LoadColumn(12)]
        public DateTime Yr_built { get; set; } //1


        [ColumnName("yr_renovated"), LoadColumn(13)]
        public DateTime Yr_renovated { get; set; } //1


        [ColumnName("street"), LoadColumn(14)]
        public string Street { get; set; } //0


        [ColumnName("city"), LoadColumn(15)]
        public string City { get; set; } //0


        [ColumnName("statezip"), LoadColumn(16)]
        public string Statezip { get; set; } //0


        [ColumnName("country"), LoadColumn(17)]
        public string Country { get; set; } //0
    }
}
