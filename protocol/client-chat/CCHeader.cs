  public struct CCHeader : Header
    {
        MessageType type;
        MessageState state;
        Cookie cookie;


        public CCHeader(MessageType type, MessageState state, Cookie cookie)
        {
            this.type = type;
            this.state = state;
            this.cookie = cookie;

        }

        public MessageState State
        {
            get { return this.state; }
            set { state = value; }
        }

        public MessageType Type
        {
            get { return type; }
            set { type = value; }
        }

        public Cookie Cookie
        {
            get { return cookie; }
            set { cookie = value; }
        }

    }
