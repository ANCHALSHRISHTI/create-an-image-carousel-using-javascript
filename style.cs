*{
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}
body{
    background-color: rgb(61, 60, 60);
    height: 100vh;
    display: flex;
    justify-content: center;
    align-items: center;
}
.container{
    width: 700px;
    height: 450px;
    border: 20px solid white;
    position: relative;
}
.prev,.next {
    position: absolute;
    top: 40%;
    font-size: 25px;
    font-weight: bold;
    color: white;
    
  }
  .prev{
    left: 20px;
  }
  .next{
    right:20px;
  }
  .navigation-btn {
    display: flex;
    justify-content: center;
    align-items: center;
    cursor: pointer;
    width: 40px;
    height: 40px;
    border-radius: 50%;
    background-color: grey;
    transition: 0.5s;
    z-index: 10;
  }
  .navigation-btn:hover {
    background-color: white;
    color: black;
  }
  .car-container img {
    width: 660px;
    height: 405px;
  }
  .item {
    position: absolute;
    display: none;
  }
  .show {
    display: block;
  }
  .car-container {
    position: relative;
  }
  .item .cap {
    position: absolute;
    bottom: 0px;
    width: 100%;
    display: flex;
    justify-content: center;
    background-color: rgba(0, 0, 0, 0.365);
    align-items: center;
    color: white;
    height: 35px;
  }
