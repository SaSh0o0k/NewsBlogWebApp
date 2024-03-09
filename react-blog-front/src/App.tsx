import React from "react";
import { Route, Routes } from "react-router-dom";
// import MainPage from "./component/mainPage.tsx";
import PostList from "./component/PostList.tsx";

const App: React.FC = () => {

  return(
    <Routes>
      <Route path="/">
        <Route index element={<PostList/>}/>

      </Route>
    </Routes>

      // <BrowserRouter>
      //     <Routes>
      //         <Route path="/" element={<MainPage/>}/>
      //         <Route path="/tag/:tagUrlSlug" element={<MainPage/>}/>
      //     </Routes>
      // </BrowserRouter>
  );
}

export default App;