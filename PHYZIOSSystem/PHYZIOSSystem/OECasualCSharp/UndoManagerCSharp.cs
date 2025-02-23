using System;
using System.Collections.Generic;
using oec;
namespace OECasualCSharp
{
    public class UndoManagerCSharp
    {
        internal int LevelsOfUndo
        {
            get
            {
                return this.undoStack.Count + this.redoStack.Count + this.cache.Count;
            }
            set
            {
                this.Clear();
                for (int i = 0; i < value; i++)
                {
                    this.cache.AddLast(new ClipboardManaged());
                }
                foreach (ClipboardManaged clipboardManaged in this.cache)
                {
                    clipboardManaged.ResetClipboard();
                }
            }
        }
        internal void CopyAll(SceneWrap scene)
        {
            this.edit.Clear();
            this.edit.AddLast(new ClipboardManaged());
            this.edit.Last.Value.CopyAll(scene);
        }
        internal void CopySelection(SceneWrap scene)
        {
            this.edit.Clear();
            this.edit.AddLast(new ClipboardManaged());
            this.edit.Last.Value.CopySelection(scene);
        }
        internal void Paste(SceneWrap scene)
        {
            if (this.edit.Count > 0)
            {
                this.edit.Last.Value.Paste(scene);
            }
        }
        internal int GetUndoCount()
        {
            return this.undoStack.Count;
        }
        internal bool IsCopyExist()
        {
            return this.edit.Count > 0;
        }
        internal int GetRedoCount()
        {
            return this.redoStack.Count;
        }
        internal void Redo(SceneWrap scene)
        {
            if (this.redoStack.Count > 0)
            {
                ClipboardManaged value = this.redoStack.Last.Value;
                this.redoStack.RemoveLast();
                value.Swap(scene);
                this.undoStack.AddFirst(value);
            }
        }
        internal void RegisterUndo(SceneWrap scene)
        {
            while (this.redoStack.Count > 0)
            {
                this.cache.AddLast(this.redoStack.Last.Value);
                this.redoStack.RemoveLast();
            }
            ClipboardManaged clipboardManaged;
            if (this.cache.Count > 0)
            {
                clipboardManaged = this.cache.Last.Value;
                this.cache.RemoveLast();
            }
            else
            {
                if (this.undoStack.Count <= 0)
                {
                    return;
                }
                clipboardManaged = this.undoStack.Last.Value;
                this.undoStack.RemoveLast();
            }
            clipboardManaged.CopyAll(scene);
            this.undoStack.AddFirst(clipboardManaged);
        }
        internal void Undo(SceneWrap scene)
        {
            if (this.undoStack.Count > 0)
            {
                ClipboardManaged value = this.undoStack.First.Value;
                this.undoStack.RemoveFirst();
                ClipboardManaged clipboardManaged = new ClipboardManaged();
                clipboardManaged.CopyAll(scene);
                value.Swap(scene);
                this.redoStack.AddLast(clipboardManaged);
            }
        }
        internal void Clear()
        {
            while (this.undoStack.Count > 0)
            {
                this.cache.AddLast(this.undoStack.First.Value);
                this.undoStack.RemoveFirst();
            }
            while (this.redoStack.Count > 0)
            {
                this.cache.AddLast(this.redoStack.Last.Value);
                this.redoStack.RemoveLast();
            }
        }
        private LinkedList<ClipboardManaged> undoStack = new LinkedList<ClipboardManaged>();
        private LinkedList<ClipboardManaged> redoStack = new LinkedList<ClipboardManaged>();
        private LinkedList<ClipboardManaged> cache = new LinkedList<ClipboardManaged>();
        private LinkedList<ClipboardManaged> edit = new LinkedList<ClipboardManaged>();
    }
}
