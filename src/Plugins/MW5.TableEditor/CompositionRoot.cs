﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Plugins.Mvp;
using MW5.Plugins.TableEditor.BO;
using MW5.Plugins.TableEditor.Editor;
using MW5.Plugins.TableEditor.Forms;

namespace MW5.Plugins.TableEditor
{
    public static class CompositionRoot
    {
        private static bool composed = false;

        public static void Compose(IApplicationContainer container)
        {
            if (!composed)
            {
                container.RegisterSingleton<TableEditorPresenter, TableEditorPresenter>();
                container.RegisterSingleton<AppContextWrapper, AppContextWrapper>();
                container.RegisterService<ITableEditorView, TableEditorView>();
                composed = true;
            }
        }
    }
}
