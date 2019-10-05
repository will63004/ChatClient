﻿namespace UISystem
{
    public interface IUIView
    {
        void Open(int id);
        void Close(int id);
        void Refresh(int id);
    }
}
