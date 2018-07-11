using System;

namespace Microting.WindowsService.BasePn
{
    public interface ISdkEventHandler
    {
        void CoreEventException(object sender, EventArgs args);
        void UnitActivated(object sender, EventArgs args);
        void eFormProcessed(object sender, EventArgs args);
        void eFormProcessingError(object sender, EventArgs args);
        void eFormRetrived(object sender, EventArgs args);
        void CaseCompleted(object sender, EventArgs args);
        void CaseDeleted(object sender, EventArgs args);
        void NotificationNotFound(object sender, EventArgs args);
    }
}
