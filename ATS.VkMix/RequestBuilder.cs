namespace ATS.VkMix
{
    public class RequestBuilder
    {
        private readonly VkMixRequest _vkMixRequest;

        public RequestBuilder()
        {
            _vkMixRequest = new VkMixRequest();
        }
        
        public RequestBuilder SetApiKey(string key)
        {
            _vkMixRequest.ApiKey = key;
            return this;
        }

        public RequestBuilder SetTaskType(string type)
        {
            _vkMixRequest.RequestType = type;
            return this;
        }
        
        public RequestBuilder SetNetwork(string network)
        {
            _vkMixRequest.Network = network;
            return this;
        }
        
        public RequestBuilder SetSection(string selection)
        {
            _vkMixRequest.Section = selection;
            return this;
        }
        
        public RequestBuilder SetLink(string link)
        {
            _vkMixRequest.Link = link;
            return this;
        }
        
        public RequestBuilder SetCount(string count)
        {
            _vkMixRequest.Count = count;
            return this;
        }
        
        public RequestBuilder SetAmount(string amount)
        {
            _vkMixRequest.Amount = amount;
            return this;
        }
        
        public RequestBuilder SetComments(params string[] comments)
        {
            _vkMixRequest.Comments = comments;
            return this;
        }
        
        public RequestBuilder SetPoll(string poll)
        {
            _vkMixRequest.Poll = poll;
            return this;
        }
        
        public RequestBuilder SetHourlyLimit(string limit)
        {
            _vkMixRequest.HourlyLimit = limit;
            return this;
        }
        
        public RequestBuilder SetIds(params string[] ids)
        {
            _vkMixRequest.Ids = ids;
            return this;
        }

        public RequestBuilder SetOffset(string offset)
        {
            _vkMixRequest.Offset = offset;
            return this;
        }

        public VkMixRequest Build()
        {
            return _vkMixRequest;
        }

    }
}