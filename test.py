from TikTokApi.TikTokApi import TikTokApi


# If playwright doesn't work for you try to use selenium
# api = TikTokApi.get_instance(use_selenium=True)

def get_trending():
    api = TikTokApi.get_instance()
    results = 10

    # Since TikTok changed their API you need to use the custom_verifyFp option.
    # In your web browser you will need to go to TikTok, Log in and get the s_v_web_id value.
    trending = api.trending(count=results, custom_verifyFp="")
    #
    # for tiktok in trending:
    #     # Prints the id of the tiktok
    #     print(tiktok)

    # print(len(trending))
    return trending
