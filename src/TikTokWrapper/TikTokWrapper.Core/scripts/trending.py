from TikTokApi import TikTokApi
import json

def get_trending():
    api = TikTokApi.get_instance()
    results = 10

    trending = api.trending(count=results, custom_verifyFp="")
    y = json.dumps(trending)
    print (y)

get_trending()