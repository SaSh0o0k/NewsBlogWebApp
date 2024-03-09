import {Post} from "./Post.ts";

export default interface PostPagesCount {
    posts: Post[];
    pagesCount: number;
}