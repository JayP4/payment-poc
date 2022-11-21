import React, { useState } from "react"

const Site = ({ setIsAdding }) => {
    const [siteName, setSiteName] = useState('');
  
    const handleAdd = e => {
      e.preventDefault();
      setIsAdding(false);
      
    };

    return (
        <div className="container">
        <form onSubmit={handleAdd}>
          <h1>Find Site</h1>
          <label htmlFor="siteName">Site Name</label>
          <input
            id="siteName"
            type="text"
            name="siteName"
            placeholder="Site 1"
            value={siteName}
            onChange={e => setSiteName(e.target.value)}
          />
          
          <div style={{ marginTop: '30px' }}>
            <input type="submit" value="Search" />
            <input
              style={{ marginLeft: '12px' }}
              className="muted-button"
              type="button"
              value="Cancel"
              onClick={() => setIsAdding(false)}
            />
          </div>
        </form>
      </div>

    )
    // return(
    //     <div className="container">
    //         <div className="py-4">
    //             
    //         </div>
    //     </div>
    // );
}

export default Site;