﻿using System;
using System.Collections.Generic;
using System.Text;

using neo4j = Neo4j.Driver;

namespace Blueprint41.Neo4j.Persistence.Driver.v5
{
    public class Neo4jBookmark : Bookmark
    {
        internal Neo4jBookmark(string[] values)
        {
            Values = values;
        }

        public string[] Values { get; private set; }

        internal neo4j.Bookmarks ToBookmark() => neo4j.Bookmarks.From(Values);

        internal static string ToTokenInternal(Bookmark consistency)
        {
            if (consistency is not Neo4jBookmark bookmark)
                return string.Empty;

            return string.Join("|", bookmark.Values);
        }
        internal static Bookmark FromTokenInternal(string consistencyToken)
        {
            if (string.IsNullOrEmpty(consistencyToken))
                return NullBookmark;

            string[] values = consistencyToken.Split(new[] { '|' });

            return new Neo4jBookmark(values);
        }
    }
}
