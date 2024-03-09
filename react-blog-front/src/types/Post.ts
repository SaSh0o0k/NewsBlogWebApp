import Tag from "./Tag.ts";

export interface Post {
  id: number;
  title: string;
  shortDescription: string;
  description: string;
  meta: string;
  urlSlug: string;
  published: boolean;
  postedOn: Date;
  modified: Date | null;
  tags: Tag[];
}