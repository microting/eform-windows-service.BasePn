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
        /// <summary>
        /// This method will start the internal threads if any.
        /// </summary>
        /// <param name="sdkConnectionString">This is required if the plugin is to start the eForm SDK</param>
        /// <param name="serviceLocation"></param>
        /// <returns></returns>
        bool Start(string sdkConnectionString, string serviceLocation);
        /// <summary>
        /// This is to shut down the internal threads the plugin might have started
        /// otherwise it should just return true.
        /// </summary>
        /// <param name="shutdownReallyFast">Optinally implemented so the plugin shuts down really fast</param>
        /// <returns></returns>
        bool Stop(bool shutdownReallyFast);
        /// <summary>
        /// If needed stops and start the internal threads of the plugin
        /// </summary>
        /// <param name="sameExceptionCount"></param>
        /// <param name="sameExceptionCountMax"></param>
        /// <param name="shutdownReallyFast">Optinally implemented so the plugin shuts down really fast</param>
        /// <returns></returns>
        bool Restart(int sameExceptionCount, int sameExceptionCountMax, bool shutdownReallyFast);
    }
}
