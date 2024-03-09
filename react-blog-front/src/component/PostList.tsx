import React, { useEffect, useState } from 'react';
// import axios from 'axios';
import { Post } from '../types/Post.ts';
import http_common from "../http_common.ts";

const PostList: React.FC = () => {
  const [posts, setPosts] = useState<Post[]>([]);

  useEffect(() => {
      http_common.get<Post[]>('/api/Post')
      .then(response => {
        setPosts(response.data);
      })
      .catch(error => {
        console.error('Error fetching posts:', error);
      });
  }), [];

  return (
    <div>
      <h2>Список постів</h2>
      <ul>
        {posts.map(post => (
          <li key={post.id}>
            <h3>{post.title}</h3>
            <p>{post.description}</p>
            <ul>
                <li>Опубліковано: {new Date(post.postedOn).toLocaleDateString('uk-UA')}</li>
                {post.modified && <li>Редаговано: {new Date(post.modified).toLocaleDateString('uk-UA')}</li>}
            </ul>
          </li>
        ))}
      </ul>
    </div>
  );
}

export default PostList;