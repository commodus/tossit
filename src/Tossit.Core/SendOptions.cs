using System;

namespace Tossit.Core
{
    /// <summary>
    /// General options to send.
    /// </summary>
    public class SendOptions
    {
        /// <summary>
        /// Default confirm receipt timeout as second. Value: 10 sec.
        /// </summary>
        private const int DEAFULT_CONFIRM_RECEIPT_TIMEOUT = 10;
        /// <summary>
        /// Default time as second for wait to retry.
        /// </summary>
        private const int DEAFULT_WAIT_TO_RETRY_SECONDS = 30;

        /// <summary>
        /// ConfirmReceiptTimeoutSeconds field.
        /// </summary>
        private int _confirmReceiptTimeoutSeconds;
        /// <summary>
        /// WaitToRetrySeconds field.
        /// </summary>
        private int _waitToRetrySeconds;

        /// <summary>
        /// Default 10 seconds. Wait until a dispatched data have been confirmed.
        /// Returns default if not specified.
        /// </summary>
        public virtual int ConfirmReceiptTimeoutSeconds
        {
            get
            {
                return _confirmReceiptTimeoutSeconds > 0 ? _confirmReceiptTimeoutSeconds : DEAFULT_CONFIRM_RECEIPT_TIMEOUT;
            }
            set
            {
                _confirmReceiptTimeoutSeconds = value;
            }
        }

        /// <summary>
        /// Set true if u want to wait to see the message received successfully from broker until timeout. Otherwise should be false.
        /// It is highly recommended to be true.
        /// Default: true.
        /// </summary>
        public virtual bool ConfirmReceiptIsActive { get; set; } = true;

        /// <summary>
        /// Time as second for wait to retry.
        /// Should be greater then zero.
        /// Default: 30 seconds.
        /// </summary>
        public virtual int WaitToRetrySeconds
        {
            get
            {
                return _waitToRetrySeconds > 0 ? _waitToRetrySeconds : DEAFULT_WAIT_TO_RETRY_SECONDS;
            }
            set
            {
                if (value <= 0) throw new ArgumentException("WaitToRetrySeconds should be greater then zero.");

                _waitToRetrySeconds = value;
            }
        }
    }
}