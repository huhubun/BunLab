<template>
  <section class="pure-g main">
    <item v-for="p in properties" :item="p" :key="p.propertyName"/>
  </section>
</template>

<script>
import { UAItem } from './UAItem'

import Item from './item.vue'

export default {
  data() {
    return {
      properties: [
        new UAItem('userAgent', 'https://developer.mozilla.org/docs/Web/API/NavigatorID/userAgent'),
        new UAItem('appCodeName', 'https://developer.mozilla.org/docs/Web/API/NavigatorID/appCodeName'),
        new UAItem('appName', 'https://developer.mozilla.org/docs/Web/API/NavigatorID/appName'),
        new UAItem('cookieEnabled', 'https://developer.mozilla.org/docs/Web/API/Navigator/cookieEnabled'),
        new UAItem('language', 'https://developer.mozilla.org/docs/Web/API/NavigatorLanguage/language')
      ]
    }
  },
  components: {
    Item
  }
}
</script>

<style lang="stylus" scoped>
</style>
