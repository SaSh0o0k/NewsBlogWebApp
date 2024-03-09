// import axios from 'axios';
// import Tag from "./Tag.ts";
// import {PostPages} from "./PostPages.ts";
// import IFilteredPosts from "./PostPagesCount.ts";
//
// export const apiUrl = "http://localhost:5239";
// export const imagesDir = apiUrl + "/Data/images/";
//
// const postsControllerUrl = apiUrl + "/api/Posts/";
// const tagsControllerUrl = apiUrl + "/api/Tags/";
//
// export const getPostsAsync = async (filter: PostPages): Promise<IFilteredPosts> => {
//     const response = await axios.get<IFilteredPosts>(postsControllerUrl + "GetPage", {
//         params: filter
//     });
//     return response.data;
// }
//
// export const getTagsAsync = async (): Promise<Tag[]> => {
//     const response = await axios.get<Tag[]>(tagsControllerUrl + "List");
//     return response.data;
// }