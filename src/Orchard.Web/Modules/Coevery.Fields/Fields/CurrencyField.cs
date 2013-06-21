﻿using System;
using Orchard.ContentManagement;
using Orchard.ContentManagement.FieldStorage;

namespace Coevery.Fields.Fields {
    public class CurrencyField : ContentField {

        public decimal? Value {
            get { return Storage.Get<decimal?>(); }

            set { Storage.Set(value??0M); }
        }
    }
}
