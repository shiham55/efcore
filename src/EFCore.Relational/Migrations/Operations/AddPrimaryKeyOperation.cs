// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Diagnostics;
using JetBrains.Annotations;

namespace Microsoft.EntityFrameworkCore.Migrations.Operations
{
    /// <summary>
    ///     A <see cref="MigrationOperation" /> to add a new foreign key.
    /// </summary>
    [DebuggerDisplay("ALTER TABLE {Table} ADD CONSTRAINT {Name} PRIMARY KEY")]
    public class AddPrimaryKeyOperation : MigrationOperation
    {
        /// <summary>
        ///     The schema that contains the table, or <c>null</c> if the default schema should be used.
        /// </summary>
        public virtual string Schema { get; [param: CanBeNull] set; }

        /// <summary>
        ///     The table to which the key should be added.
        /// </summary>
        public virtual string Table { get; [param: NotNull] set; }

        /// <summary>
        ///     The name of the foreign key constraint.
        /// </summary>
        public virtual string Name { get; [param: NotNull] set; }

        /// <summary>
        ///     The ordered-list of column names for the columns that make up the primary key.
        /// </summary>
        public virtual string[] Columns { get; [param: NotNull] set; }
    }
}
