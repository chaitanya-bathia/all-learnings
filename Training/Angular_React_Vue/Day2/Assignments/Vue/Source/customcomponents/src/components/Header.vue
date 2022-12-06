<template>
    <div class="header">
        <button id="btnHome" class="headerButton">Home</button>
        <button id="btnAbout" class="headerButton">About</button>
    </div>
</template>

<script>
export default {
    name: 'HeaderComponent'
}
</script>
<style scoped>
.header
{
    background: #000;
    color:white;
    display: flex;
    justify-content: space-evenly;
    align-items: center;
    height: 100px;
}

.headerButton
{
    
    text-align: center;
    height: 50px;
    width: 100px;
}
</style>

