﻿using System;
using System.Collections.Generic;
using Com.Shamiraa.Service.Core.Lib.Helpers;

namespace Com.Shamiraa.Service.Core.Lib.ViewModels
{
    public class ItemViewModelUsername : BasicViewModelOld
    {
        //public string code { get; set; }

        //public string name { get; set; }

        //public string Description { get; set; }

        //public string Uom { get; set; }

        //public string Tags { get; set; }

        //public string Remark { get; set; }

        //public string ArticleRealizationOrder { get; set; }

        //public string Size { get; set; }

        //public string ImagePath { get; set; }

        public List<ItemViewModelRead> dataDestination { get; set; }

        public ItemArticleColorViewModel color { get; set; }

        //public long ArticleColorsId { get; set; }

        //public string ColorCode { get; set; }

        //public string ColorDocName { get; set; }

        public ItemArticleProcesViewModel process { get; set; }

        //public long ArticleProcessId { get; set; }

        //public string ProcessDocCode { get; set; }

        //public string ProcessDocName { get; set; }

        public ItemArticleMaterialViewModel materials { get; set; }

        //public long ArticleMaterialsId { get; set; }

        //public string MaterialDocCode { get; set; }

        //public string MaterialDocName { get; set; }

        public ItemArticleMaterialCompositionViewModel materialCompositions { get; set; }

        //public long ArticleMaterialCompositionsId { get; set; }

        //public string MaterialCompositionDocCode { get; set; }

        //public string MaterialCompositionDocName { get; set; }

        public ItemArticleCollectionViewModel collections { get; set; }

        //public long ArticleCollectionsId { get; set; }

        //public string CollectionDocCode { get; set; }

        //public string CollectionDocName { get; set; }

        public ItemArticleSeasonViewModel seasons { get; set; }

        //public long ArticleSeasonsId { get; set; }

        //public string SeasonDocCode { get; set; }

        //public string SeasonDocName { get; set; }

        public ItemArticleCounterViewModel counters { get; set; }

        //public long ArticleCountersId { get; set; }

        //public string CounterDocCode { get; set; }

        //public string CounterDocName { get; set; }

        public ItemArticleSubCounterViewModel subCounters { get; set; }

        //public long ArticleSubCountersId { get; set; }

        //public string StyleDocCode { get; set; }

        //public string StyleDocName { get; set; }

        public ItemArticleCategoryViewModel categories { get; set; }

        //public long ArticleCategoriesId { get; set; }

        //public string CategoryDocCode { get; set; }

        //public string CategoryDocName { get; set; }

        public double? DomesticCOGS { get; set; }

        public double? DomesticWholesale { get; set; }

        public double? DomesticRetail { get; set; }

        public double? DomesticSale { get; set; }

        public double? InternationalCOGS { get; set; }

        public double? InternationalWholesale { get; set; }

        public double? InternationalRetail { get; set; }

        public double? InternationalSale { get; set; }
        public double? price { get; set; }
        public string ImageFile { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
        public double TotalQty { get; set; }
    }
}
